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
            int length = BitConverter.ToInt32(tmp, 0);
            byte[] fileName = new byte[length];
            client.Client.Receive(fileName, length, SocketFlags.None);
            tmp = new byte[4];
            client.Client.Receive(tmp, 4, SocketFlags.None);
            length = BitConverter.ToInt32(tmp, 0);
            byte[] fileData = new byte[length];
            int received = 0;
            Invoke(new Action(() => { ReceiveProgressLabel.Text = $"Receiving file of size {Math.Round((double)length / 1024 / 1024, 2)}MB"; }));
            while (received < length)
            {
                if (isCanceled)
                    return;
                int size = bytesToReceive < length - received ? bytesToReceive : length - received;
                received += client.GetStream().Read(fileData, received, size);
                int percent = (int)((double)received * 100 / length);
                BackgroundWorker.ReportProgress(percent);
            }

            Invoke(new Action(() => { ReceiveProgressLabel.Text = $"Writing data to file..."; }));
            File.WriteAllBytes($@"{receiveDir}\{Encoding.ASCII.GetString(fileName)}", fileData);
            MessageBox.Show("Received successfully.");
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
            ReceiveProgressBar.Value = e.ProgressPercentage;
        }
    }
}