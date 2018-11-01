namespace AdaExpWScale
{
    partial class wProgressDlg
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
            this.olaProgress = new System.Windows.Forms.Label();
            this.opgStatus = new System.Windows.Forms.ProgressBar();
            this.ocmStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // olaProgress
            // 
            this.olaProgress.AutoSize = true;
            this.olaProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaProgress.Location = new System.Drawing.Point(119, 9);
            this.olaProgress.Name = "olaProgress";
            this.olaProgress.Size = new System.Drawing.Size(80, 20);
            this.olaProgress.TabIndex = 5;
            this.olaProgress.Text = "Progress";
            // 
            // opgStatus
            // 
            this.opgStatus.Location = new System.Drawing.Point(12, 34);
            this.opgStatus.Name = "opgStatus";
            this.opgStatus.Size = new System.Drawing.Size(274, 26);
            this.opgStatus.TabIndex = 4;
            // 
            // ocmStop
            // 
            this.ocmStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmStop.Location = new System.Drawing.Point(101, 61);
            this.ocmStop.Name = "ocmStop";
            this.ocmStop.Size = new System.Drawing.Size(98, 31);
            this.ocmStop.TabIndex = 3;
            this.ocmStop.Text = "Stop";
            this.ocmStop.UseVisualStyleBackColor = true;
            this.ocmStop.Click += new System.EventHandler(this.ocmStop_Click);
            // 
            // wProgressDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(302, 97);
            this.ControlBox = false;
            this.Controls.Add(this.olaProgress);
            this.Controls.Add(this.opgStatus);
            this.Controls.Add(this.ocmStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wProgressDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress...";
            this.Load += new System.EventHandler(this.wProgressDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label olaProgress;
        private System.Windows.Forms.ProgressBar opgStatus;
        private System.Windows.Forms.Button ocmStop;
    }
}