
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
            this.ReceiveProgressBar = new System.Windows.Forms.ProgressBar();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ReceiveProgressLabel = new System.Windows.Forms.Label();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ReceiveProgressBar
            // 
            this.ReceiveProgressBar.Location = new System.Drawing.Point(12, 25);
            this.ReceiveProgressBar.Name = "ReceiveProgressBar";
            this.ReceiveProgressBar.Size = new System.Drawing.Size(260, 23);
            this.ReceiveProgressBar.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(197, 54);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // ReceiveProgressLabel
            // 
            this.ReceiveProgressLabel.AutoSize = true;
            this.ReceiveProgressLabel.Location = new System.Drawing.Point(12, 9);
            this.ReceiveProgressLabel.Name = "ReceiveProgressLabel";
            this.ReceiveProgressLabel.Size = new System.Drawing.Size(132, 13);
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
            // ReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.ReceiveProgressLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ReceiveProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceiveForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ReceiveProgressBar;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ReceiveProgressLabel;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
    }
}