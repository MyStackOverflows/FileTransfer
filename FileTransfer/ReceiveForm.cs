using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Threading.Tasks;
using System.ComponentModel;

namespace FileTransfer
{
    public partial class ReceiveForm : Form
    {
        TcpClient client;
        TcpListener server;
        Task<TcpClient> task;
        bool isCanceled = false;
        string receiveDir;
        int port;
        int bytesToReceive;
        public ReceiveForm(string _receiveDir, int _port, int _bytesToReceive)
        {
            InitializeComponent();
            receiveDir = _receiveDir;
            port = _port;
            bytesToReceive = _bytesToReceive;

            BackgroundWorker.RunWorkerAsync();
        }

        private void ReceiveMessage(object sender, DoWorkEventArgs e)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            task = server.AcceptTcpClientAsync();
            while (!task.IsCompleted)       // locks thread until it's ready to go lol
            {
                if (isCanceled)
                    return;
            }
            client = task.Result;

            byte[] tmp = new byte[4];
            client.Client.Receive(tmp, 4, SocketFlags.None);
            int totalNumber = BitConverter.ToInt32(tmp, 0);     // get total number of upcoming messages

            tmp = new byte[4];
            client.Client.Receive(tmp, 4, SocketFlags.None);
            int totalBytes = BitConverter.ToInt32(tmp, 0);      // get total size of all files to be received

            //TotalProgressBar.Maximum = totalNumber;
            Invoke(new Action(() => { TotalProgressBar.Maximum = totalBytes; }));
            int totalBytesReceived = 0;
            for (int i = 0; i < totalNumber; i++)
            {
                //TotalProgressBar.Value = i;
                //TotalProgressLabel.Text = $"{i}/{totalNumber} objects received";

                tmp = new byte[1];
                client.Client.Receive(tmp, 1, SocketFlags.None);
                if (tmp[0] == 0x00)
                {
                    tmp = new byte[4];
                    client.Client.Receive(tmp, 4, SocketFlags.None);
                    int length = BitConverter.ToInt32(tmp, 0);      // file name length

                    tmp = new byte[length];
                    client.Client.Receive(tmp, length, SocketFlags.None);
                    string fileName = Encoding.ASCII.GetString(tmp);

                    tmp = new byte[4];
                    client.Client.Receive(tmp, 4, SocketFlags.None);
                    length = BitConverter.ToInt32(tmp, 0);          // file size length

                    byte[] fileData = new byte[length];
                    int received = 0;
                    Invoke(new Action(() => { ReceiveProgressLabel.Text = $"Receiving file of size {Math.Round((double)length / 1024 / 1024, 2)} MB"; }));
                    while (received < length)
                    {
                        if (isCanceled)
                            return;
                        int size = bytesToReceive < length - received ? bytesToReceive : length - received;
                        int read = client.GetStream().Read(fileData, received, size);
                        received += read;
                        totalBytesReceived += read;
                        int percent = (int)((double)received * 100 / length);   // current file percent
                        BackgroundWorker.ReportProgress(percent);       // update current progressbar
                        try
                        {
                            Invoke(new Action(() => { TotalProgressBar.Value = totalBytesReceived; })); // update total progressbar
                            Invoke(new Action(() => { TotalProgressLabel.Text = $"{Math.Round((double)totalBytesReceived / 1024 / 1024, 2)}/{Math.Round((double)totalBytes / 1024 / 1024, 2)} MB transferred"; }));
                        }
                        catch (ObjectDisposedException) { }
                    }

                    Invoke(new Action(() => { ReceiveProgressLabel.Text = $"Writing data to file..."; }));
                    File.WriteAllBytes($@"{receiveDir}\{fileName}", fileData);
                }       // we are receiving a file
                else
                {
                    tmp = new byte[4];
                    client.Client.Receive(tmp, 4, SocketFlags.None);
                    int length = BitConverter.ToInt32(tmp, 0);

                    byte[] dirName = new byte[length];
                    client.Client.Receive(dirName, length, SocketFlags.None);

                    Directory.CreateDirectory($@"{receiveDir}\{Encoding.ASCII.GetString(dirName)}");
                }                      // we are receiving a directory
            }
            CloseForm();
        }

        private void CloseForm()
        {
            Invoke(new Action(() => { this.Close(); }));
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            isCanceled = true;
            if (client != null)
                client.Close();
            if (server != null)
                server.Stop();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            CloseForm();
        }

        // updates progressbar when backgroundworker reports progress
        private void ProgressUpdated(object sender, ProgressChangedEventArgs e)
        {
            IndividualProgressBar.Value = e.ProgressPercentage;
        }
    }
}