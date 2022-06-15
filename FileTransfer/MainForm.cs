using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

namespace FileTransfer
{
    public partial class MainForm : Form
    {
        TcpClient client;
        int total = 0;
        public MainForm()
        {
            InitializeComponent();
            LocalIPTextBox.Text = GetLocalIP().ToString();
            ReceivePathTextBox.Text = $@"C:\Users\{Environment.UserName}\Downloads";
        }

        // recursive method to loop through all nodes in the FileTreeView and send a message for each one
        private void SendAll(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                SendMessage(node.Tag.ToString(), node.FullPath);
                if (node.Nodes.Count > 0)
                    SendAll(node.Nodes);
            }
        }

        // sends the individual messages
        private void SendMessage(string path, string final)
        {
            byte[] msg;
            if (File.Exists(path))
            {
                FileInfo info = new FileInfo(path);
                msg = new byte[info.Length + final.Length + 9];
                msg[0] = 0x00;      // 0x00 means file, 0x01 means directory

                // first byte = file/dir indicator, next 4 bytes = name length x, next x bytes is name, next 4 bytes = file size in bytes y, next y bytes = file
                long i = 1;
                Array.Copy(BitConverter.GetBytes(final.Length), 0, msg, i, 4); i += 4;
                Array.Copy(Encoding.ASCII.GetBytes(final), 0, msg, i, final.Length); i += final.Length;
                Array.Copy(BitConverter.GetBytes((int)info.Length), 0, msg, i, 4); i += 4;
                Array.Copy(File.ReadAllBytes(info.FullName), 0, msg, i, info.Length);
            }
            else if (Directory.Exists(path))
            {
                DirectoryInfo info = new DirectoryInfo(path);
                msg = new byte[final.Length + 5];
                msg[0] = 0x01;      // 0x00 means file, 0x01 means directory

                // first byte = file/dir indicator, next 4 bytes = name length x, next x bytes is name
                Array.Copy(BitConverter.GetBytes(final.Length), 0, msg, 1, 4);
                Array.Copy(Encoding.ASCII.GetBytes(final), 0, msg, 5, final.Length);
            }
            else
            {
                // invalid path
                MessageBox.Show($"The path specified ({path}) is not valid. Skipping this file.");
                return;
            }
            // sending msg
            client.Client.Send(msg, msg.Length, SocketFlags.None);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            if (name.Equals("SendBrowseButton"))
            {
                // select and add files
                if (FilesRadioButton.Checked)
                {
                    DialogResult res = OpenFileDialog.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        for (int i = 0; i < OpenFileDialog.FileNames.Length; i++)
                        {
                            TreeNode node = FileTreeView.Nodes.Add(OpenFileDialog.SafeFileNames[i]);    // node.Text = file name
                            node.Tag = OpenFileDialog.FileNames[i];                                     // node.Tag = full file path
                            total++;
                        }
                    }
                }
                // select and add a folder
                else
                {
                    DialogResult res = FolderBrowserDialog.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        DirectoryInfo dir = new DirectoryInfo(FolderBrowserDialog.SelectedPath);
                        TreeNode node = FileTreeView.Nodes.Add(dir.Name);
                        node.Tag = dir.FullName;
                        AddDirectory(dir, node);
                        total++;
                    }
                }
            }
            else if (name.Equals("RemoveButton"))
            {
                TreeNode node = FileTreeView.SelectedNode;
                total -= (node.GetNodeCount(true) + 1);
                node.Remove();
            }
            else if (name.Equals("ReceiveBrowseButton"))
            {
                DialogResult res = FolderBrowserDialog.ShowDialog();
                if (res == DialogResult.OK)
                    ReceivePathTextBox.Text = FolderBrowserDialog.SelectedPath;
            }
            else if (name.Equals("SendButton"))
            {
                if (FileTreeView.Nodes.Count == 0)
                    PrintDebug("No files were specified to send, operation canceled.", "Error");
                else
                {
                    client = GetClient();
                    if (client == null)
                        PrintDebug("Invalid IP format or IP was not open, operation canceled.", "Error");
                    else
                    {
                        // send initial message to let the receiver know how many individual messages are following
                        byte[] msg = new byte[4];
                        Array.Copy(BitConverter.GetBytes(total), 0, msg, 0, 4);
                        client.Client.Send(msg, msg.Length, SocketFlags.None);

                        // send another initial message to let the receiver know the total number of bytes coming (so total progress bar can be accurate)
                        long totalBytes = 0;
                        foreach (TreeNode node in FileTreeView.Nodes)   // calculate total size of all files and directories including sub-directories
                        {
                            string path = node.Tag.ToString();
                            if (File.Exists(path))
                                totalBytes += new FileInfo(path).Length;        // add size of file to totalBytes
                            else if (Directory.Exists(path))
                                totalBytes += new DirectoryInfo(path).GetFiles("*.*", SearchOption.AllDirectories).Sum(f => f.Length);    // add size of all files and sub-files to totalBytes
                        }
                        msg = new byte[4];
                        Array.Copy(BitConverter.GetBytes((int)totalBytes), 0, msg, 0, 4);
                        client.Client.Send(msg, msg.Length, SocketFlags.None);

                        // send a message for every node in FileTreeView
                        SendAll(FileTreeView.Nodes);

                        client.Close();
                        client = null;
                    }
                }
            }
            else if (name.Equals("ReceiveButton"))
            {
                if (!Directory.Exists(ReceivePathTextBox.Text))
                    PrintDebug("The directory specified for receiving does not exist, operation canceled.", "Error");
                else
                {
                    new ReceiveForm(ReceivePathTextBox.Text, (int)PortNumUpDown.Value, (int)BytesPerIterationNumUpDown.Value * 1024 * 1024).ShowDialog();
                }
            }
            else if (name.Equals("OpenReceiveFolderButton"))
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "explorer.exe";
                info.Arguments = $"{ReceivePathTextBox.Text}";
                Process p = new Process();
                p.StartInfo = info;
                p.Start();
            }
        }

        // recursive method to add a directory and all subfiles and directories to the file treeview
        private void AddDirectory(DirectoryInfo dir, TreeNode parent)
        {
            foreach (DirectoryInfo child in dir.GetDirectories())
            {
                TreeNode node = parent.Nodes.Add(child.Name);
                node.Tag = child.FullName;
                AddDirectory(child, node);
                total++;
            }
            foreach (FileInfo file in dir.GetFiles())
            {
                TreeNode node = parent.Nodes.Add(file.Name);
                node.Tag = file.FullName;
                total++;
            }
        }

        private TcpClient GetClient()
        {
            try { return new TcpClient(IPAddress.Parse(RemoteIPTextBox.Text).ToString(), (int)PortNumUpDown.Value); }
            catch { return null; }
        }

        private IPAddress GetLocalIP()
        {
            List<IPAddress> addresses = Dns.GetHostAddresses(Dns.GetHostName()).ToList();
            IPAddress address = IPAddress.Any;
            foreach (IPAddress i in addresses)
                if (!i.ToString().Contains(":"))
                    address = i;
            return address;
        }

        private void PrintDebug(string msg, string title = "")
        {
            MessageBox.Show(msg, title);
        }
    }
}