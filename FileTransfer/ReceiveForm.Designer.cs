
namespace FileTransfer
{
    partial class ReceiveForm
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
            this.IndividualProgressBar = new System.Windows.Forms.ProgressBar();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ReceiveProgressLabel = new System.Windows.Forms.Label();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.TotalProgressBar = new System.Windows.Forms.ProgressBar();
            this.TotalProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IndividualProgressBar
            // 
            this.IndividualProgressBar.Location = new System.Drawing.Point(12, 27);
            this.IndividualProgressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IndividualProgressBar.Name = "IndividualProgressBar";
            this.IndividualProgressBar.Size = new System.Drawing.Size(305, 18);
            this.IndividualProgressBar.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(230, 100);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(88, 27);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // ReceiveProgressLabel
            // 
            this.ReceiveProgressLabel.AutoSize = true;
            this.ReceiveProgressLabel.Location = new System.Drawing.Point(13, 9);
            this.ReceiveProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceiveProgressLabel.Name = "ReceiveProgressLabel";
            this.ReceiveProgressLabel.Size = new System.Drawing.Size(147, 15);
            this.ReceiveProgressLabel.TabIndex = 2;
            this.ReceiveProgressLabel.Text = "Waiting for a connection...";
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReceiveMessage);
            this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ProgressUpdated);
            // 
            // TotalProgressBar
            // 
            this.TotalProgressBar.Location = new System.Drawing.Point(12, 69);
            this.TotalProgressBar.Name = "TotalProgressBar";
            this.TotalProgressBar.Size = new System.Drawing.Size(305, 25);
            this.TotalProgressBar.TabIndex = 3;
            // 
            // TotalProgressLabel
            // 
            this.TotalProgressLabel.AutoSize = true;
            this.TotalProgressLabel.Location = new System.Drawing.Point(13, 51);
            this.TotalProgressLabel.Name = "TotalProgressLabel";
            this.TotalProgressLabel.Size = new System.Drawing.Size(105, 15);
            this.TotalProgressLabel.TabIndex = 4;
            this.TotalProgressLabel.Text = "0/x MB transferred";
            // 
            // ReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 136);
            this.Controls.Add(this.TotalProgressLabel);
            this.Controls.Add(this.TotalProgressBar);
            this.Controls.Add(this.ReceiveProgressLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.IndividualProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ReceiveForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar IndividualProgressBar;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ReceiveProgressLabel;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private ProgressBar TotalProgressBar;
        private Label TotalProgressLabel;
    }
}