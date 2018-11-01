namespace AdaExpWScale
{
    partial class wLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wLogin));
            this.ocmOk = new System.Windows.Forms.Button();
            this.ocmCancel = new System.Windows.Forms.Button();
            this.olaUserLogin = new System.Windows.Forms.Label();
            this.olaUserName = new System.Windows.Forms.Label();
            this.olaUserPassword = new System.Windows.Forms.Label();
            this.otbUserName = new System.Windows.Forms.TextBox();
            this.otbUserPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.olaBrand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ocmOk
            // 
            this.ocmOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmOk.Image = ((System.Drawing.Image)(resources.GetObject("ocmOk.Image")));
            this.ocmOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmOk.Location = new System.Drawing.Point(160, 103);
            this.ocmOk.Name = "ocmOk";
            this.ocmOk.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ocmOk.Size = new System.Drawing.Size(87, 36);
            this.ocmOk.TabIndex = 0;
            this.ocmOk.Text = "OK";
            this.ocmOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmOk.UseVisualStyleBackColor = true;
            this.ocmOk.Click += new System.EventHandler(this.ocmOk_Click);
            // 
            // ocmCancel
            // 
            this.ocmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmCancel.Image = ((System.Drawing.Image)(resources.GetObject("ocmCancel.Image")));
            this.ocmCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmCancel.Location = new System.Drawing.Point(306, 103);
            this.ocmCancel.Name = "ocmCancel";
            this.ocmCancel.Size = new System.Drawing.Size(87, 36);
            this.ocmCancel.TabIndex = 1;
            this.ocmCancel.Text = "CANCEL";
            this.ocmCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmCancel.UseVisualStyleBackColor = true;
            this.ocmCancel.Click += new System.EventHandler(this.ocmCancel_Click);
            // 
            // olaUserLogin
            // 
            this.olaUserLogin.AutoSize = true;
            this.olaUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaUserLogin.Location = new System.Drawing.Point(156, 9);
            this.olaUserLogin.Name = "olaUserLogin";
            this.olaUserLogin.Size = new System.Drawing.Size(109, 20);
            this.olaUserLogin.TabIndex = 2;
            this.olaUserLogin.Text = "USER LOGIN";
            // 
            // olaUserName
            // 
            this.olaUserName.AutoSize = true;
            this.olaUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaUserName.Location = new System.Drawing.Point(157, 43);
            this.olaUserName.Name = "olaUserName";
            this.olaUserName.Size = new System.Drawing.Size(70, 15);
            this.olaUserName.TabIndex = 3;
            this.olaUserName.Text = "User Name";
            // 
            // olaUserPassword
            // 
            this.olaUserPassword.AutoSize = true;
            this.olaUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaUserPassword.Location = new System.Drawing.Point(157, 70);
            this.olaUserPassword.Name = "olaUserPassword";
            this.olaUserPassword.Size = new System.Drawing.Size(90, 15);
            this.olaUserPassword.TabIndex = 4;
            this.olaUserPassword.Text = "User Password";
            // 
            // otbUserName
            // 
            this.otbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbUserName.Location = new System.Drawing.Point(253, 40);
            this.otbUserName.Name = "otbUserName";
            this.otbUserName.Size = new System.Drawing.Size(140, 21);
            this.otbUserName.TabIndex = 5;
            // 
            // otbUserPassword
            // 
            this.otbUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbUserPassword.Location = new System.Drawing.Point(253, 67);
            this.otbUserPassword.Name = "otbUserPassword";
            this.otbUserPassword.PasswordChar = '*';
            this.otbUserPassword.Size = new System.Drawing.Size(140, 21);
            this.otbUserPassword.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // olaBrand
            // 
            this.olaBrand.AutoSize = true;
            this.olaBrand.Location = new System.Drawing.Point(313, 153);
            this.olaBrand.Name = "olaBrand";
            this.olaBrand.Size = new System.Drawing.Size(80, 13);
            this.olaBrand.TabIndex = 8;
            this.olaBrand.Text = "Adasoft Co.,Ltd";
            // 
            // wLogin
            // 
            this.AcceptButton = this.ocmOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ocmCancel;
            this.ClientSize = new System.Drawing.Size(405, 171);
            this.ControlBox = false;
            this.Controls.Add(this.olaBrand);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.otbUserPassword);
            this.Controls.Add(this.otbUserName);
            this.Controls.Add(this.olaUserPassword);
            this.Controls.Add(this.olaUserName);
            this.Controls.Add(this.olaUserLogin);
            this.Controls.Add(this.ocmCancel);
            this.Controls.Add(this.ocmOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ocmOk;
        private System.Windows.Forms.Button ocmCancel;
        private System.Windows.Forms.Label olaUserLogin;
        private System.Windows.Forms.Label olaUserName;
        private System.Windows.Forms.Label olaUserPassword;
        private System.Windows.Forms.TextBox otbUserName;
        private System.Windows.Forms.TextBox otbUserPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label olaBrand;
    }
}