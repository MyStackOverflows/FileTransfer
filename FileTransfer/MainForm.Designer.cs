
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
            this.ReceivePathTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.NetworkInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.BytesPerIterationNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.SendBrowseButton = new System.Windows.Forms.Button();
            this.ReceiveBrowseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FileInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FolderRadioButton = new System.Windows.Forms.RadioButton();
            this.FilesRadioButton = new System.Windows.Forms.RadioButton();
            this.FileTreeView = new System.Windows.Forms.TreeView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenReceiveFolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumUpDown)).BeginInit();
            this.NetworkInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BytesPerIterationNumUpDown)).BeginInit();
            this.FileInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalIPTextBox
            // 
            this.LocalIPTextBox.Location = new System.Drawing.Point(102, 17);
            this.LocalIPTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LocalIPTextBox.Name = "LocalIPTextBox";
            this.LocalIPTextBox.ReadOnly = true;
            this.LocalIPTextBox.Size = new System.Drawing.Size(96, 23);
            this.LocalIPTextBox.TabIndex = 1;
            this.LocalIPTextBox.Text = "255.255.255.255";
            this.LocalIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // PortNumUpDown
            // 
            this.PortNumUpDown.Location = new System.Drawing.Point(102, 47);
            this.PortNumUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.PortNumUpDown.Size = new System.Drawing.Size(96, 23);
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
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remote IP:";
            // 
            // RemoteIPTextBox
            // 
            this.RemoteIPTextBox.Location = new System.Drawing.Point(102, 77);
            this.RemoteIPTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoteIPTextBox.Name = "RemoteIPTextBox";
            this.RemoteIPTextBox.Size = new System.Drawing.Size(96, 23);
            this.RemoteIPTextBox.TabIndex = 6;
            this.RemoteIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReceiveButton
            // 
            this.ReceiveButton.Location = new System.Drawing.Point(301, 192);
            this.ReceiveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(88, 27);
            this.ReceiveButton.TabIndex = 7;
            this.ReceiveButton.Text = "Receive";
            this.ReceiveButton.UseVisualStyleBackColor = true;
            this.ReceiveButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ReceivePathTextBox
            // 
            this.ReceivePathTextBox.Location = new System.Drawing.Point(301, 165);
            this.ReceivePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReceivePathTextBox.Name = "ReceivePathTextBox";
            this.ReceivePathTextBox.ReadOnly = true;
            this.ReceivePathTextBox.Size = new System.Drawing.Size(145, 23);
            this.ReceivePathTextBox.TabIndex = 9;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(419, 192);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(88, 27);
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
            this.NetworkInformationGroupBox.Location = new System.Drawing.Point(301, 0);
            this.NetworkInformationGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NetworkInformationGroupBox.Name = "NetworkInformationGroupBox";
            this.NetworkInformationGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NetworkInformationGroupBox.Size = new System.Drawing.Size(206, 141);
            this.NetworkInformationGroupBox.TabIndex = 11;
            this.NetworkInformationGroupBox.TabStop = false;
            this.NetworkInformationGroupBox.Text = "Network information";
            // 
            // BytesPerIterationNumUpDown
            // 
            this.BytesPerIterationNumUpDown.Location = new System.Drawing.Point(124, 107);
            this.BytesPerIterationNumUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.BytesPerIterationNumUpDown.Size = new System.Drawing.Size(75, 23);
            this.BytesPerIterationNumUpDown.TabIndex = 8;
            this.BytesPerIterationNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BytesPerIterationNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "MB received/cycle:";
            // 
            // SendBrowseButton
            // 
            this.SendBrowseButton.Location = new System.Drawing.Point(117, 190);
            this.SendBrowseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendBrowseButton.Name = "SendBrowseButton";
            this.SendBrowseButton.Size = new System.Drawing.Size(51, 23);
            this.SendBrowseButton.TabIndex = 12;
            this.SendBrowseButton.Text = "Add...";
            this.SendBrowseButton.UseVisualStyleBackColor = true;
            this.SendBrowseButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ReceiveBrowseButton
            // 
            this.ReceiveBrowseButton.Location = new System.Drawing.Point(454, 165);
            this.ReceiveBrowseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReceiveBrowseButton.Name = "ReceiveBrowseButton";
            this.ReceiveBrowseButton.Size = new System.Drawing.Size(53, 23);
            this.ReceiveBrowseButton.TabIndex = 13;
            this.ReceiveBrowseButton.Text = "Browse";
            this.ReceiveBrowseButton.UseVisualStyleBackColor = true;
            this.ReceiveBrowseButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Receive folder:";
            // 
            // FileInformationGroupBox
            // 
            this.FileInformationGroupBox.Controls.Add(this.RemoveButton);
            this.FileInformationGroupBox.Controls.Add(this.FolderRadioButton);
            this.FileInformationGroupBox.Controls.Add(this.FilesRadioButton);
            this.FileInformationGroupBox.Controls.Add(this.FileTreeView);
            this.FileInformationGroupBox.Controls.Add(this.SendBrowseButton);
            this.FileInformationGroupBox.Location = new System.Drawing.Point(3, 0);
            this.FileInformationGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FileInformationGroupBox.Name = "FileInformationGroupBox";
            this.FileInformationGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FileInformationGroupBox.Size = new System.Drawing.Size(290, 219);
            this.FileInformationGroupBox.TabIndex = 16;
            this.FileInformationGroupBox.TabStop = false;
            this.FileInformationGroupBox.Text = "File information";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(4, 190);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveButton.TabIndex = 22;
            this.RemoveButton.Text = "Remove selected";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // FolderRadioButton
            // 
            this.FolderRadioButton.AutoSize = true;
            this.FolderRadioButton.Location = new System.Drawing.Point(225, 192);
            this.FolderRadioButton.Name = "FolderRadioButton";
            this.FolderRadioButton.Size = new System.Drawing.Size(56, 19);
            this.FolderRadioButton.TabIndex = 19;
            this.FolderRadioButton.Text = "folder";
            this.FolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // FilesRadioButton
            // 
            this.FilesRadioButton.AutoSize = true;
            this.FilesRadioButton.Checked = true;
            this.FilesRadioButton.Location = new System.Drawing.Point(175, 192);
            this.FilesRadioButton.Name = "FilesRadioButton";
            this.FilesRadioButton.Size = new System.Drawing.Size(46, 19);
            this.FilesRadioButton.TabIndex = 18;
            this.FilesRadioButton.TabStop = true;
            this.FilesRadioButton.Text = "files";
            this.FilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // FileTreeView
            // 
            this.FileTreeView.HideSelection = false;
            this.FileTreeView.Location = new System.Drawing.Point(5, 13);
            this.FileTreeView.Name = "FileTreeView";
            this.FileTreeView.Size = new System.Drawing.Size(280, 175);
            this.FileTreeView.TabIndex = 17;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Multiselect = true;
            // 
            // OpenReceiveFolderButton
            // 
            this.OpenReceiveFolderButton.Location = new System.Drawing.Point(454, 141);
            this.OpenReceiveFolderButton.Name = "OpenReceiveFolderButton";
            this.OpenReceiveFolderButton.Size = new System.Drawing.Size(53, 23);
            this.OpenReceiveFolderButton.TabIndex = 17;
            this.OpenReceiveFolderButton.Text = "Open";
            this.OpenReceiveFolderButton.UseVisualStyleBackColor = true;
            this.OpenReceiveFolderButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 223);
            this.Controls.Add(this.OpenReceiveFolderButton);
            this.Controls.Add(this.FileInformationGroupBox);
            this.Controls.Add(this.NetworkInformationGroupBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ReceiveButton);
            this.Controls.Add(this.ReceivePathTextBox);
            this.Controls.Add(this.ReceiveBrowseButton);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Send files via TCP";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumUpDown)).EndInit();
            this.NetworkInformationGroupBox.ResumeLayout(false);
            this.NetworkInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BytesPerIterationNumUpDown)).EndInit();
            this.FileInformationGroupBox.ResumeLayout(false);
            this.FileInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LocalIPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PortNumUpDown;
        private System.Windows.Forms.TextBox RemoteIPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReceiveButton;
        private System.Windows.Forms.TextBox ReceivePathTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox NetworkInformationGroupBox;
        private System.Windows.Forms.Button SendBrowseButton;
        private System.Windows.Forms.Button ReceiveBrowseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox FileInformationGroupBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.NumericUpDown BytesPerIterationNumUpDown;
        private System.Windows.Forms.Label label6;
        private TreeView FileTreeView;
        private RadioButton FolderRadioButton;
        private RadioButton FilesRadioButton;
        private Button RemoveButton;
        private Button OpenReceiveFolderButton;
    }
}

