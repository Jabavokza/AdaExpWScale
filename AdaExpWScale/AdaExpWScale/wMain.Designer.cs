namespace AdaExpWScale
{
    partial class wMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wMain));
            this.ocmExit = new System.Windows.Forms.Button();
            this.ocmSetting = new System.Windows.Forms.Button();
            this.olaHD = new System.Windows.Forms.Label();
            this.oBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ocmExport = new System.Windows.Forms.Button();
            this.opbWeigth = new System.Windows.Forms.PictureBox();
            this.olaBrand = new System.Windows.Forms.Label();
            this.olaFormateFile = new System.Windows.Forms.Label();
            this.olaFormate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opbWeigth)).BeginInit();
            this.SuspendLayout();
            // 
            // ocmExit
            // 
            this.ocmExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocmExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmExit.Image = ((System.Drawing.Image)(resources.GetObject("ocmExit.Image")));
            this.ocmExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmExit.Location = new System.Drawing.Point(276, 185);
            this.ocmExit.Name = "ocmExit";
            this.ocmExit.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.ocmExit.Size = new System.Drawing.Size(173, 61);
            this.ocmExit.TabIndex = 7;
            this.ocmExit.Text = "EXIT";
            this.ocmExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmExit.UseVisualStyleBackColor = true;
            this.ocmExit.Click += new System.EventHandler(this.ocmExit_Click);
            // 
            // ocmSetting
            // 
            this.ocmSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ocmSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmSetting.Image = ((System.Drawing.Image)(resources.GetObject("ocmSetting.Image")));
            this.ocmSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmSetting.Location = new System.Drawing.Point(276, 109);
            this.ocmSetting.Name = "ocmSetting";
            this.ocmSetting.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.ocmSetting.Size = new System.Drawing.Size(173, 61);
            this.ocmSetting.TabIndex = 6;
            this.ocmSetting.Text = "SETTING";
            this.ocmSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmSetting.UseVisualStyleBackColor = true;
            this.ocmSetting.Click += new System.EventHandler(this.ocmSetting_Click);
            // 
            // olaHD
            // 
            this.olaHD.AutoSize = true;
            this.olaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaHD.Location = new System.Drawing.Point(125, 35);
            this.olaHD.Name = "olaHD";
            this.olaHD.Size = new System.Drawing.Size(285, 25);
            this.olaHD.TabIndex = 4;
            this.olaHD.Text = "Export Data to Weight scale ";
            // 
            // oBackgroundWorker
            // 
            this.oBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.oBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.oBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // ocmExport
            // 
            this.ocmExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmExport.Image = ((System.Drawing.Image)(resources.GetObject("ocmExport.Image")));
            this.ocmExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmExport.Location = new System.Drawing.Point(29, 109);
            this.ocmExport.Name = "ocmExport";
            this.ocmExport.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.ocmExport.Size = new System.Drawing.Size(220, 137);
            this.ocmExport.TabIndex = 8;
            this.ocmExport.Text = "ExportFile";
            this.ocmExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmExport.UseVisualStyleBackColor = true;
            this.ocmExport.Click += new System.EventHandler(this.ocmExport_Click);
            // 
            // opbWeigth
            // 
            this.opbWeigth.Image = ((System.Drawing.Image)(resources.GetObject("opbWeigth.Image")));
            this.opbWeigth.Location = new System.Drawing.Point(29, 12);
            this.opbWeigth.Name = "opbWeigth";
            this.opbWeigth.Size = new System.Drawing.Size(90, 80);
            this.opbWeigth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbWeigth.TabIndex = 9;
            this.opbWeigth.TabStop = false;
            // 
            // olaBrand
            // 
            this.olaBrand.AutoSize = true;
            this.olaBrand.Location = new System.Drawing.Point(369, 278);
            this.olaBrand.Name = "olaBrand";
            this.olaBrand.Size = new System.Drawing.Size(80, 13);
            this.olaBrand.TabIndex = 10;
            this.olaBrand.Text = "Adasoft Co.,Ltd";
            // 
            // olaFormateFile
            // 
            this.olaFormateFile.AutoSize = true;
            this.olaFormateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFormateFile.Location = new System.Drawing.Point(26, 264);
            this.olaFormateFile.Name = "olaFormateFile";
            this.olaFormateFile.Size = new System.Drawing.Size(106, 16);
            this.olaFormateFile.TabIndex = 11;
            this.olaFormateFile.Text = "FormateFile แบบ:";
            // 
            // olaFormate
            // 
            this.olaFormate.AutoSize = true;
            this.olaFormate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFormate.Location = new System.Drawing.Point(157, 264);
            this.olaFormate.Name = "olaFormate";
            this.olaFormate.Size = new System.Drawing.Size(50, 16);
            this.olaFormate.TabIndex = 12;
            this.olaFormate.Text = "Default";
            // 
            // wMain
            // 
            this.AcceptButton = this.ocmExport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ocmExit;
            this.ClientSize = new System.Drawing.Size(462, 300);
            this.Controls.Add(this.olaFormate);
            this.Controls.Add(this.olaFormateFile);
            this.Controls.Add(this.olaBrand);
            this.Controls.Add(this.opbWeigth);
            this.Controls.Add(this.ocmExport);
            this.Controls.Add(this.ocmExit);
            this.Controls.Add(this.ocmSetting);
            this.Controls.Add(this.olaHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "wMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportFile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wMain_FormClosing);
            this.Load += new System.EventHandler(this.wMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opbWeigth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ocmExit;
        private System.Windows.Forms.Button ocmSetting;
        private System.Windows.Forms.Label olaHD;
        private System.ComponentModel.BackgroundWorker oBackgroundWorker;
        private System.Windows.Forms.Button ocmExport;
        private System.Windows.Forms.PictureBox opbWeigth;
        private System.Windows.Forms.Label olaBrand;
        private System.Windows.Forms.Label olaFormateFile;
        public System.Windows.Forms.Label olaFormate;
    }
}

