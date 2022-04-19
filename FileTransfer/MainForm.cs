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

namespace FileTransfer
{
    public partial class MainForm : Form
    {
        TcpClient client;
        public MainForm()
        {
            InitializeComponent();
            LocalIPTextBox.Text = GetLocalIP().ToString();
        }

        private void SendMessage()
        {
            // msg[0] is the file name length of x bytes. next x bytes is the file name. msg[x + 1] is the file length of y bytes. next y bytes is the file data
            // creating msg
            FileInfo f = new FileInfo(SendPathTextBox.Text);

            byte[] msg = new byte[f.Length + f.Name.Length + 12];
            long i = 0;
            Array.Copy(BitConverter.GetBytes(f.Name.Length), 0, msg, i, 4);
            i += 4;
            Array.Copy(Encoding.ASCII.GetBytes(f.Name), 0, msg, i, f.Name.Length);
            i += f.Name.Length;
            Array.Copy(BitConverter.GetBytes((int)f.Length), 0, msg, i, 4);
            i += 4;
            Array.Copy(File.ReadAllBytes(f.FullName), 0, msg, i, f.Length);
            i += f.Length;

            // sending msg
            client.Client.Send(msg, msg.Length, SocketFlags.None);

            // clean up
            client.Close();
            client = null;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            if (name.Equals("SendBrowseButton"))
            {
                DialogResult res = OpenFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                    SendPathTextBox.Text = OpenFileDialog.FileName;
            }
            else if (name.Equals("ReceiveBrowseButton"))
            {
                DialogResult res = FolderBrowserDialog.ShowDialog();
                if (res == DialogResult.OK)
                    ReceivePathTextBox.Text = FolderBrowserDialog.SelectedPath;
            }
            else if (name.Equals("SendButton"))
            {
                if (SendPathTextBox.Text.Equals(""))
                    PrintDebug("No file was specified to send, operation canceled.", "Error");
                else
                {
                    client = GetClient();
                    if (client == null)
                        PrintDebug("Invalid IP format or IP was not open, operation canceled.", "Error");
                    else
                        SendMessage();
                }
            }
            else if (name.Equals("ReceiveButton"))
            {
                if (ReceivePathTextBox.Text.Equals(""))
                    PrintDebug("No folder was specified to receive, operation canceled.", "Error");
                else
                {
                    new ReceiveForm(ReceivePathTextBox.Text, (int)PortNumUpDown.Value, (int)BytesPerIterationNumUpDown.Value * 1024 * 1024).ShowDialog();
                }
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