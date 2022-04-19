
namespace FileTransfer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocalIPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoteIPTextBox = new System.Windows.Forms.TextBox();
            this.ReceiveButton = new System.Windows.Forms.Button();
            this.SendPathTextBox = new System.Windows.Forms.TextBox();
            this.ReceivePathTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.NetworkInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.SendBrowseButton = new System.Windows.Forms.Button();
            this.ReceiveBrowseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.BytesPerIterationNumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumUpDown)).BeginInit();
            this.NetworkInformationGroupBox.SuspendLayout();
            this.FileInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BytesPerIterationNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalIPTextBox
            // 
            this.LocalIPTextBox.Location = new System.Drawing.Point(72, 16);
            this.LocalIPTextBox.Name = "LocalIPTextBox";
            this.LocalIPTextBox.ReadOnly = true;
            this.LocalIPTextBox.Size = new System.Drawing.Size(104, 20);
            this.LocalIPTextBox.TabIndex = 1;
            this.LocalIPTextBox.Text = "255.255.255.255";
            this.LocalIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // PortNumUpDown
            // 
            this.PortNumUpDown.Location = new System.Drawing.Point(72, 42);
            this.PortNumUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortNumUpDown.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.PortNumUpDown.Name = "PortNumUpDown";
            this.PortNumUpDown.Size = new System.Drawing.Size(104, 20);
            this.PortNumUpDown.TabIndex = 4;
            this.PortNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PortNumUpDown.Value = new decimal(new int[] {
            2002,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remote IP:";
            // 
            // RemoteIPTextBox
            // 
            this.RemoteIPTextBox.Location = new System.Drawing.Point(72, 68);
            this.RemoteIPTextBox.Name = "RemoteIPTextBox";
            this.RemoteIPTextBox.Size = new System.Drawing.Size(104, 20);
            this.RemoteIPTextBox.TabIndex = 6;
            this.RemoteIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReceiveButton
            // 
            this.ReceiveButton.Location = new System.Drawing.Point(354, 93);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(75, 23);
            this.ReceiveButton.TabIndex = 7;
            this.ReceiveButton.Text = "Receive";
            this.ReceiveButton.UseVisualStyleBackColor = true;
            this.ReceiveButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // SendPathTextBox
            // 
            this.SendPathTextBox.Location = new System.Drawing.Point(62, 17);
            this.SendPathTextBox.Name = "SendPathTextBox";
            this.SendPathTextBox.ReadOnly = true;
            this.SendPathTextBox.Size = new System.Drawing.Size(180, 20);
            this.SendPathTextBox.TabIndex = 8;
            // 
            // ReceivePathTextBox
            // 
            this.ReceivePathTextBox.Location = new System.Drawing.Point(62, 45);
            this.ReceivePathTextBox.Name = "ReceivePathTextBox";
            this.ReceivePathTextBox.ReadOnly = true;
            this.ReceivePathTextBox.Size = new System.Drawing.Size(180, 20);
            this.ReceivePathTextBox.TabIndex = 9;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(435, 93);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 10;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NetworkInformationGroupBox
            // 
            this.NetworkInformationGroupBox.Controls.Add(this.BytesPerIterationNumUpDown);
            this.NetworkInformationGroupBox.Controls.Add(this.label6);
            this.NetworkInformationGroupBox.Controls.Add(this.LocalIPTextBox);
            this.NetworkInformationGroupBox.Controls.Add(this.label2);
            this.NetworkInformationGroupBox.Controls.Add(this.PortNumUpDown);
            this.NetworkInformationGroupBox.Controls.Add(this.label1);
            this.NetworkInformationGroupBox.Controls.Add(this.label3);
            this.NetworkInformationGroupBox.Controls.Add(this.RemoteIPTextBox);
            this.NetworkInformationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.NetworkInformationGroupBox.Name = "NetworkInformationGroupBox";
            this.NetworkInformationGroupBox.Size = new System.Drawing.Size(185, 122);
            this.NetworkInformationGroupBox.TabIndex = 11;
            this.NetworkInformationGroupBox.TabStop = false;
            this.NetworkInformationGroupBox.Text = "Network information";
            // 
            // SendBrowseButton
            // 
            this.SendBrowseButton.Location = new System.Drawing.Point(248, 15);
            this.SendBrowseButton.Name = "SendBrowseButton";
            this.SendBrowseButton.Size = new System.Drawing.Size(52, 23);
            this.SendBrowseButton.TabIndex = 12;
            this.SendBrowseButton.Text = "Browse";
            this.SendBrowseButton.UseVisualStyleBackColor = true;
            this.SendBrowseButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ReceiveBrowseButton
            // 
            this.ReceiveBrowseButton.Location = new System.Drawing.Point(248, 43);
            this.ReceiveBrowseButton.Name = "ReceiveBrowseButton";
            this.ReceiveBrowseButton.Size = new System.Drawing.Size(52, 23);
            this.ReceiveBrowseButton.TabIndex = 13;
            this.ReceiveBrowseButton.Text = "Browse";
            this.ReceiveBrowseButton.UseVisualStyleBackColor = true;
            this.ReceiveBrowseButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Send:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Receive:";
            // 
            // FileInformationGroupBox
            // 
            this.FileInformationGroupBox.Controls.Add(this.label5);
            this.FileInformationGroupBox.Controls.Add(this.SendPathTextBox);
            this.FileInformationGroupBox.Controls.Add(this.label4);
            this.FileInformationGroupBox.Controls.Add(this.ReceivePathTextBox);
            this.FileInformationGroupBox.Controls.Add(this.ReceiveBrowseButton);
            this.FileInformationGroupBox.Controls.Add(this.SendBrowseButton);
            this.FileInformationGroupBox.Location = new System.Drawing.Point(203, 12);
            this.FileInformationGroupBox.Name = "FileInformationGroupBox";
            this.FileInformationGroupBox.Size = new System.Drawing.Size(307, 75);
            this.FileInformationGroupBox.TabIndex = 16;
            this.FileInformationGroupBox.TabStop = false;
            this.FileInformationGroupBox.Text = "File information";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "MB received/cycle:";
            // 
            // BytesPerIterationNumUpDown
            // 
            this.BytesPerIterationNumUpDown.Location = new System.Drawing.Point(112, 94);
            this.BytesPerIterationNumUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BytesPerIterationNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BytesPerIterationNumUpDown.Name = "BytesPerIterationNumUpDown";
            this.BytesPerIterationNumUpDown.Size = new System.Drawing.Size(64, 20);
            this.BytesPerIterationNumUpDown.TabIndex = 8;
            this.BytesPerIterationNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BytesPerIterationNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 141);
            this.Controls.Add(this.FileInformationGroupBox);
            this.Controls.Add(this.NetworkInformationGroupBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ReceiveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Send files via TCP";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumUpDown)).EndInit();
            this.NetworkInformationGroupBox.ResumeLayout(false);
            this.NetworkInformationGroupBox.PerformLayout();
            this.FileInformationGroupBox.ResumeLayout(false);
            this.FileInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BytesPerIterationNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox LocalIPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PortNumUpDown;
        private System.Windows.Forms.TextBox RemoteIPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReceiveButton;
        private System.Windows.Forms.TextBox SendPathTextBox;
        private System.Windows.Forms.TextBox ReceivePathTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox NetworkInformationGroupBox;
        private System.Windows.Forms.Button SendBrowseButton;
        private System.Windows.Forms.Button ReceiveBrowseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox FileInformationGroupBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.NumericUpDown BytesPerIterationNumUpDown;
        private System.Windows.Forms.Label label6;
    }
}

