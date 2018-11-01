namespace AdaExpWScale
{
    partial class wSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wSetting));
            this.ocmExportPath = new System.Windows.Forms.Button();
            this.ocbDbName = new System.Windows.Forms.ComboBox();
            this.otbExportPath = new System.Windows.Forms.TextBox();
            this.otbUserPassword = new System.Windows.Forms.TextBox();
            this.otbUserName = new System.Windows.Forms.TextBox();
            this.otbDbLocation = new System.Windows.Forms.TextBox();
            this.olaExportPath = new System.Windows.Forms.Label();
            this.olaDbName = new System.Windows.Forms.Label();
            this.olaUserPassword = new System.Windows.Forms.Label();
            this.olaUserName = new System.Windows.Forms.Label();
            this.olaDbLocation = new System.Windows.Forms.Label();
            this.ocmClose = new System.Windows.Forms.Button();
            this.ocmSaveSetting = new System.Windows.Forms.Button();
            this.olaRefreshDbName = new System.Windows.Forms.Button();
            this.ogbNameAndPathConfig = new System.Windows.Forms.GroupBox();
            this.ogbNo4 = new System.Windows.Forms.GroupBox();
            this.otbPathSQL4 = new System.Windows.Forms.TextBox();
            this.olaFileSQL4 = new System.Windows.Forms.Label();
            this.ocmFileSQL4 = new System.Windows.Forms.Button();
            this.olaFileName4 = new System.Windows.Forms.Label();
            this.otbFileName4 = new System.Windows.Forms.TextBox();
            this.ogbNo2 = new System.Windows.Forms.GroupBox();
            this.otbPathSQL2 = new System.Windows.Forms.TextBox();
            this.olaFileSQL2 = new System.Windows.Forms.Label();
            this.ocmFileSQL2 = new System.Windows.Forms.Button();
            this.olaFileName2 = new System.Windows.Forms.Label();
            this.otbFileName2 = new System.Windows.Forms.TextBox();
            this.ogbNo3 = new System.Windows.Forms.GroupBox();
            this.otbPathSQL3 = new System.Windows.Forms.TextBox();
            this.olaFileSQL3 = new System.Windows.Forms.Label();
            this.ocmFileSQL3 = new System.Windows.Forms.Button();
            this.olaFileName3 = new System.Windows.Forms.Label();
            this.otbFileName3 = new System.Windows.Forms.TextBox();
            this.ogbNo1 = new System.Windows.Forms.GroupBox();
            this.otbPathSQL1 = new System.Windows.Forms.TextBox();
            this.olaFileSQL1 = new System.Windows.Forms.Label();
            this.ocmFileSQL1 = new System.Windows.Forms.Button();
            this.olaFileName1 = new System.Windows.Forms.Label();
            this.otbFileName1 = new System.Windows.Forms.TextBox();
            this.oBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ogbConfigDb = new System.Windows.Forms.GroupBox();
            this.olaBrand = new System.Windows.Forms.Label();
            this.ogbFormateFile = new System.Windows.Forms.GroupBox();
            this.olaANSI = new System.Windows.Forms.Label();
            this.orbWindows874 = new System.Windows.Forms.RadioButton();
            this.orbUTF8 = new System.Windows.Forms.RadioButton();
            this.ogbNameAndPathConfig.SuspendLayout();
            this.ogbNo4.SuspendLayout();
            this.ogbNo2.SuspendLayout();
            this.ogbNo3.SuspendLayout();
            this.ogbNo1.SuspendLayout();
            this.ogbConfigDb.SuspendLayout();
            this.ogbFormateFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // ocmExportPath
            // 
            this.ocmExportPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ocmExportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmExportPath.Image = ((System.Drawing.Image)(resources.GetObject("ocmExportPath.Image")));
            this.ocmExportPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmExportPath.Location = new System.Drawing.Point(424, 513);
            this.ocmExportPath.Name = "ocmExportPath";
            this.ocmExportPath.Size = new System.Drawing.Size(86, 41);
            this.ocmExportPath.TabIndex = 26;
            this.ocmExportPath.Text = "Open";
            this.ocmExportPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmExportPath.UseVisualStyleBackColor = true;
            this.ocmExportPath.Click += new System.EventHandler(this.ocmExportPath_Click);
            // 
            // ocbDbName
            // 
            this.ocbDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocbDbName.FormattingEnabled = true;
            this.ocbDbName.Items.AddRange(new object[] {
            "POSSDB_TESTSAP"});
            this.ocbDbName.Location = new System.Drawing.Point(134, 112);
            this.ocbDbName.Name = "ocbDbName";
            this.ocbDbName.Size = new System.Drawing.Size(215, 23);
            this.ocbDbName.TabIndex = 25;
            // 
            // otbExportPath
            // 
            this.otbExportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbExportPath.Location = new System.Drawing.Point(112, 523);
            this.otbExportPath.Name = "otbExportPath";
            this.otbExportPath.Size = new System.Drawing.Size(310, 21);
            this.otbExportPath.TabIndex = 24;
            // 
            // otbUserPassword
            // 
            this.otbUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbUserPassword.Location = new System.Drawing.Point(134, 80);
            this.otbUserPassword.Name = "otbUserPassword";
            this.otbUserPassword.PasswordChar = '*';
            this.otbUserPassword.Size = new System.Drawing.Size(215, 21);
            this.otbUserPassword.TabIndex = 23;
            // 
            // otbUserName
            // 
            this.otbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbUserName.Location = new System.Drawing.Point(134, 48);
            this.otbUserName.Name = "otbUserName";
            this.otbUserName.Size = new System.Drawing.Size(215, 21);
            this.otbUserName.TabIndex = 22;
            // 
            // otbDbLocation
            // 
            this.otbDbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbDbLocation.Location = new System.Drawing.Point(134, 16);
            this.otbDbLocation.Name = "otbDbLocation";
            this.otbDbLocation.Size = new System.Drawing.Size(215, 21);
            this.otbDbLocation.TabIndex = 21;
            // 
            // olaExportPath
            // 
            this.olaExportPath.AutoSize = true;
            this.olaExportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaExportPath.Location = new System.Drawing.Point(22, 525);
            this.olaExportPath.Name = "olaExportPath";
            this.olaExportPath.Size = new System.Drawing.Size(87, 15);
            this.olaExportPath.TabIndex = 20;
            this.olaExportPath.Text = "Export Path To";
            // 
            // olaDbName
            // 
            this.olaDbName.AutoSize = true;
            this.olaDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaDbName.Location = new System.Drawing.Point(31, 115);
            this.olaDbName.Name = "olaDbName";
            this.olaDbName.Size = new System.Drawing.Size(61, 15);
            this.olaDbName.TabIndex = 19;
            this.olaDbName.Text = "DB Name";
            // 
            // olaUserPassword
            // 
            this.olaUserPassword.AutoSize = true;
            this.olaUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaUserPassword.Location = new System.Drawing.Point(31, 83);
            this.olaUserPassword.Name = "olaUserPassword";
            this.olaUserPassword.Size = new System.Drawing.Size(90, 15);
            this.olaUserPassword.TabIndex = 18;
            this.olaUserPassword.Text = "User Password";
            // 
            // olaUserName
            // 
            this.olaUserName.AutoSize = true;
            this.olaUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaUserName.Location = new System.Drawing.Point(31, 51);
            this.olaUserName.Name = "olaUserName";
            this.olaUserName.Size = new System.Drawing.Size(70, 15);
            this.olaUserName.TabIndex = 17;
            this.olaUserName.Text = "User Name";
            // 
            // olaDbLocation
            // 
            this.olaDbLocation.AutoSize = true;
            this.olaDbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaDbLocation.Location = new System.Drawing.Point(31, 19);
            this.olaDbLocation.Name = "olaDbLocation";
            this.olaDbLocation.Size = new System.Drawing.Size(74, 15);
            this.olaDbLocation.TabIndex = 16;
            this.olaDbLocation.Text = "DB Location";
            // 
            // ocmClose
            // 
            this.ocmClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocmClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmClose.Image = ((System.Drawing.Image)(resources.GetObject("ocmClose.Image")));
            this.ocmClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ocmClose.Location = new System.Drawing.Point(428, 79);
            this.ocmClose.Name = "ocmClose";
            this.ocmClose.Size = new System.Drawing.Size(80, 70);
            this.ocmClose.TabIndex = 15;
            this.ocmClose.Text = "Close";
            this.ocmClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ocmClose.UseVisualStyleBackColor = true;
            this.ocmClose.Click += new System.EventHandler(this.ocmClose_Click);
            // 
            // ocmSaveSetting
            // 
            this.ocmSaveSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmSaveSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ocmSaveSetting.Image = ((System.Drawing.Image)(resources.GetObject("ocmSaveSetting.Image")));
            this.ocmSaveSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ocmSaveSetting.Location = new System.Drawing.Point(428, 5);
            this.ocmSaveSetting.Name = "ocmSaveSetting";
            this.ocmSaveSetting.Size = new System.Drawing.Size(80, 70);
            this.ocmSaveSetting.TabIndex = 14;
            this.ocmSaveSetting.Text = "Save ";
            this.ocmSaveSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ocmSaveSetting.UseVisualStyleBackColor = true;
            this.ocmSaveSetting.Click += new System.EventHandler(this.ocmSaveSetting_Click);
            // 
            // olaRefreshDbName
            // 
            this.olaRefreshDbName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.olaRefreshDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaRefreshDbName.Image = ((System.Drawing.Image)(resources.GetObject("olaRefreshDbName.Image")));
            this.olaRefreshDbName.Location = new System.Drawing.Point(353, 112);
            this.olaRefreshDbName.Name = "olaRefreshDbName";
            this.olaRefreshDbName.Size = new System.Drawing.Size(42, 24);
            this.olaRefreshDbName.TabIndex = 27;
            this.olaRefreshDbName.UseVisualStyleBackColor = true;
            this.olaRefreshDbName.Click += new System.EventHandler(this.olaRefreshDbName_Click);
            // 
            // ogbNameAndPathConfig
            // 
            this.ogbNameAndPathConfig.Controls.Add(this.ogbNo4);
            this.ogbNameAndPathConfig.Controls.Add(this.ogbNo2);
            this.ogbNameAndPathConfig.Controls.Add(this.ogbNo3);
            this.ogbNameAndPathConfig.Controls.Add(this.ogbNo1);
            this.ogbNameAndPathConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogbNameAndPathConfig.Location = new System.Drawing.Point(17, 155);
            this.ogbNameAndPathConfig.Name = "ogbNameAndPathConfig";
            this.ogbNameAndPathConfig.Size = new System.Drawing.Size(501, 330);
            this.ogbNameAndPathConfig.TabIndex = 28;
            this.ogbNameAndPathConfig.TabStop = false;
            this.ogbNameAndPathConfig.Text = "ConfigFileName AND SQLFile";
            // 
            // ogbNo4
            // 
            this.ogbNo4.Controls.Add(this.otbPathSQL4);
            this.ogbNo4.Controls.Add(this.olaFileSQL4);
            this.ogbNo4.Controls.Add(this.ocmFileSQL4);
            this.ogbNo4.Controls.Add(this.olaFileName4);
            this.ogbNo4.Controls.Add(this.otbFileName4);
            this.ogbNo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogbNo4.Location = new System.Drawing.Point(10, 244);
            this.ogbNo4.Name = "ogbNo4";
            this.ogbNo4.Size = new System.Drawing.Size(483, 80);
            this.ogbNo4.TabIndex = 9;
            this.ogbNo4.TabStop = false;
            this.ogbNo4.Text = "No.4";
            // 
            // otbPathSQL4
            // 
            this.otbPathSQL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbPathSQL4.Location = new System.Drawing.Point(86, 39);
            this.otbPathSQL4.Name = "otbPathSQL4";
            this.otbPathSQL4.Size = new System.Drawing.Size(344, 21);
            this.otbPathSQL4.TabIndex = 10;
            // 
            // olaFileSQL4
            // 
            this.olaFileSQL4.AutoSize = true;
            this.olaFileSQL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFileSQL4.Location = new System.Drawing.Point(22, 42);
            this.olaFileSQL4.Name = "olaFileSQL4";
            this.olaFileSQL4.Size = new System.Drawing.Size(54, 15);
            this.olaFileSQL4.TabIndex = 9;
            this.olaFileSQL4.Text = "FileSQL:";
            // 
            // ocmFileSQL4
            // 
            this.ocmFileSQL4.Image = ((System.Drawing.Image)(resources.GetObject("ocmFileSQL4.Image")));
            this.ocmFileSQL4.Location = new System.Drawing.Point(432, 35);
            this.ocmFileSQL4.Name = "ocmFileSQL4";
            this.ocmFileSQL4.Size = new System.Drawing.Size(45, 28);
            this.ocmFileSQL4.TabIndex = 8;
            this.ocmFileSQL4.UseVisualStyleBackColor = true;
            this.ocmFileSQL4.Click += new System.EventHandler(this.ocmFileSQL4_Click);
            // 
            // olaFileName4
            // 
            this.olaFileName4.AutoSize = true;
            this.olaFileName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFileName4.Location = new System.Drawing.Point(22, 19);
            this.olaFileName4.Name = "olaFileName4";
            this.olaFileName4.Size = new System.Drawing.Size(64, 15);
            this.olaFileName4.TabIndex = 7;
            this.olaFileName4.Text = "FileName:";
            // 
            // otbFileName4
            // 
            this.otbFileName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbFileName4.Location = new System.Drawing.Point(86, 16);
            this.otbFileName4.Name = "otbFileName4";
            this.otbFileName4.Size = new System.Drawing.Size(200, 21);
            this.otbFileName4.TabIndex = 3;
            // 
            // ogbNo2
            // 
            this.ogbNo2.Controls.Add(this.otbPathSQL2);
            this.ogbNo2.Controls.Add(this.olaFileSQL2);
            this.ogbNo2.Controls.Add(this.ocmFileSQL2);
            this.ogbNo2.Controls.Add(this.olaFileName2);
            this.ogbNo2.Controls.Add(this.otbFileName2);
            this.ogbNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogbNo2.Location = new System.Drawing.Point(10, 82);
            this.ogbNo2.Name = "ogbNo2";
            this.ogbNo2.Size = new System.Drawing.Size(483, 80);
            this.ogbNo2.TabIndex = 9;
            this.ogbNo2.TabStop = false;
            this.ogbNo2.Text = "No.2";
            // 
            // otbPathSQL2
            // 
            this.otbPathSQL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbPathSQL2.Location = new System.Drawing.Point(86, 39);
            this.otbPathSQL2.Name = "otbPathSQL2";
            this.otbPathSQL2.Size = new System.Drawing.Size(344, 21);
            this.otbPathSQL2.TabIndex = 8;
            // 
            // olaFileSQL2
            // 
            this.olaFileSQL2.AutoSize = true;
            this.olaFileSQL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFileSQL2.Location = new System.Drawing.Point(22, 42);
            this.olaFileSQL2.Name = "olaFileSQL2";
            this.olaFileSQL2.Size = new System.Drawing.Size(54, 15);
            this.olaFileSQL2.TabIndex = 8;
            this.olaFileSQL2.Text = "FileSQL:";
            // 
            // ocmFileSQL2
            // 
            this.ocmFileSQL2.Image = ((System.Drawing.Image)(resources.GetObject("ocmFileSQL2.Image")));
            this.ocmFileSQL2.Location = new System.Drawing.Point(432, 35);
            this.ocmFileSQL2.Name = "ocmFileSQL2";
            this.ocmFileSQL2.Size = new System.Drawing.Size(45, 28);
            this.ocmFileSQL2.TabIndex = 7;
            this.ocmFileSQL2.UseVisualStyleBackColor = true;
            this.ocmFileSQL2.Click += new System.EventHandler(this.ocmFileSQL2_Click);
            // 
            // olaFileName2
            // 
            this.olaFileName2.AutoSize = true;
            this.olaFileName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFileName2.Location = new System.Drawing.Point(22, 19);
            this.olaFileName2.Name = "olaFileName2";
            this.olaFileName2.Size = new System.Drawing.Size(64, 15);
            this.olaFileName2.TabIndex = 5;
            this.olaFileName2.Text = "FileName:";
            // 
            // otbFileName2
            // 
            this.otbFileName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbFileName2.Location = new System.Drawing.Point(86, 16);
            this.otbFileName2.Name = "otbFileName2";
            this.otbFileName2.Size = new System.Drawing.Size(200, 21);
            this.otbFileName2.TabIndex = 1;
            // 
            // ogbNo3
            // 
            this.ogbNo3.Controls.Add(this.otbPathSQL3);
            this.ogbNo3.Controls.Add(this.olaFileSQL3);
            this.ogbNo3.Controls.Add(this.ocmFileSQL3);
            this.ogbNo3.Controls.Add(this.olaFileName3);
            this.ogbNo3.Controls.Add(this.otbFileName3);
            this.ogbNo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogbNo3.Location = new System.Drawing.Point(10, 163);
            this.ogbNo3.Name = "ogbNo3";
            this.ogbNo3.Size = new System.Drawing.Size(483, 80);
            this.ogbNo3.TabIndex = 9;
            this.ogbNo3.TabStop = false;
            this.ogbNo3.Text = "No.3";
            // 
            // otbPathSQL3
            // 
            this.otbPathSQL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbPathSQL3.Location = new System.Drawing.Point(86, 39);
            this.otbPathSQL3.Name = "otbPathSQL3";
            this.otbPathSQL3.Size = new System.Drawing.Size(344, 21);
            this.otbPathSQL3.TabIndex = 9;
            // 
            // olaFileSQL3
            // 
            this.olaFileSQL3.AutoSize = true;
            this.olaFileSQL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFileSQL3.Location = new System.Drawing.Point(22, 42);
            this.olaFileSQL3.Name = "olaFileSQL3";
            this.olaFileSQL3.Size = new System.Drawing.Size(54, 15);
            this.olaFileSQL3.TabIndex = 8;
            this.olaFileSQL3.Text = "FileSQL:";
            // 
            // ocmFileSQL3
            // 
            this.ocmFileSQL3.Image = ((System.Drawing.Image)(resources.GetObject("ocmFileSQL3.Image")));
            this.ocmFileSQL3.Location = new System.Drawing.Point(432, 35);
            this.ocmFileSQL3.Name = "ocmFileSQL3";
            this.ocmFileSQL3.Size = new System.Drawing.Size(45, 28);
            this.ocmFileSQL3.TabIndex = 7;
            this.ocmFileSQL3.UseVisualStyleBackColor = true;
            this.ocmFileSQL3.Click += new System.EventHandler(this.ocmFileSQL3_Click);
            // 
            // olaFileName3
            // 
            this.olaFileName3.AutoSize = true;
            this.olaFileName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFileName3.Location = new System.Drawing.Point(22, 19);
            this.olaFileName3.Name = "olaFileName3";
            this.olaFileName3.Size = new System.Drawing.Size(64, 15);
            this.olaFileName3.TabIndex = 6;
            this.olaFileName3.Text = "FileName:";
            // 
            // otbFileName3
            // 
            this.otbFileName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbFileName3.Location = new System.Drawing.Point(86, 16);
            this.otbFileName3.Name = "otbFileName3";
            this.otbFileName3.Size = new System.Drawing.Size(200, 21);
            this.otbFileName3.TabIndex = 2;
            // 
            // ogbNo1
            // 
            this.ogbNo1.Controls.Add(this.otbPathSQL1);
            this.ogbNo1.Controls.Add(this.olaFileSQL1);
            this.ogbNo1.Controls.Add(this.ocmFileSQL1);
            this.ogbNo1.Controls.Add(this.olaFileName1);
            this.ogbNo1.Controls.Add(this.otbFileName1);
            this.ogbNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogbNo1.Location = new System.Drawing.Point(10, 15);
            this.ogbNo1.Name = "ogbNo1";
            this.ogbNo1.Size = new System.Drawing.Size(483, 66);
            this.ogbNo1.TabIndex = 8;
            this.ogbNo1.TabStop = false;
            this.ogbNo1.Text = "No.1";
            // 
            // otbPathSQL1
            // 
            this.otbPathSQL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbPathSQL1.Location = new System.Drawing.Point(86, 39);
            this.otbPathSQL1.Name = "otbPathSQL1";
            this.otbPathSQL1.Size = new System.Drawing.Size(344, 21);
            this.otbPathSQL1.TabIndex = 7;
            // 
            // olaFileSQL1
            // 
            this.olaFileSQL1.AutoSize = true;
            this.olaFileSQL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFileSQL1.Location = new System.Drawing.Point(22, 42);
            this.olaFileSQL1.Name = "olaFileSQL1";
            this.olaFileSQL1.Size = new System.Drawing.Size(54, 15);
            this.olaFileSQL1.TabIndex = 6;
            this.olaFileSQL1.Text = "FileSQL:";
            // 
            // ocmFileSQL1
            // 
            this.ocmFileSQL1.Image = ((System.Drawing.Image)(resources.GetObject("ocmFileSQL1.Image")));
            this.ocmFileSQL1.Location = new System.Drawing.Point(432, 35);
            this.ocmFileSQL1.Name = "ocmFileSQL1";
            this.ocmFileSQL1.Size = new System.Drawing.Size(45, 28);
            this.ocmFileSQL1.TabIndex = 5;
            this.ocmFileSQL1.UseVisualStyleBackColor = true;
            this.ocmFileSQL1.Click += new System.EventHandler(this.ocmFileSQL1_Click);
            // 
            // olaFileName1
            // 
            this.olaFileName1.AutoSize = true;
            this.olaFileName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaFileName1.Location = new System.Drawing.Point(22, 19);
            this.olaFileName1.Name = "olaFileName1";
            this.olaFileName1.Size = new System.Drawing.Size(64, 15);
            this.olaFileName1.TabIndex = 4;
            this.olaFileName1.Text = "FileName:";
            // 
            // otbFileName1
            // 
            this.otbFileName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbFileName1.Location = new System.Drawing.Point(86, 16);
            this.otbFileName1.Name = "otbFileName1";
            this.otbFileName1.Size = new System.Drawing.Size(200, 21);
            this.otbFileName1.TabIndex = 0;
            // 
            // oBackgroundWorker
            // 
            this.oBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.oBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.oBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // ogbConfigDb
            // 
            this.ogbConfigDb.Controls.Add(this.olaDbLocation);
            this.ogbConfigDb.Controls.Add(this.olaUserName);
            this.ogbConfigDb.Controls.Add(this.olaRefreshDbName);
            this.ogbConfigDb.Controls.Add(this.olaUserPassword);
            this.ogbConfigDb.Controls.Add(this.olaDbName);
            this.ogbConfigDb.Controls.Add(this.ocbDbName);
            this.ogbConfigDb.Controls.Add(this.otbDbLocation);
            this.ogbConfigDb.Controls.Add(this.otbUserName);
            this.ogbConfigDb.Controls.Add(this.otbUserPassword);
            this.ogbConfigDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogbConfigDb.Location = new System.Drawing.Point(17, -1);
            this.ogbConfigDb.Name = "ogbConfigDb";
            this.ogbConfigDb.Size = new System.Drawing.Size(405, 150);
            this.ogbConfigDb.TabIndex = 29;
            this.ogbConfigDb.TabStop = false;
            this.ogbConfigDb.Text = "ConfigDB";
            // 
            // olaBrand
            // 
            this.olaBrand.AutoSize = true;
            this.olaBrand.Location = new System.Drawing.Point(438, 558);
            this.olaBrand.Name = "olaBrand";
            this.olaBrand.Size = new System.Drawing.Size(80, 13);
            this.olaBrand.TabIndex = 30;
            this.olaBrand.Text = "Adasoft Co.,Ltd";
            // 
            // ogbFormateFile
            // 
            this.ogbFormateFile.Controls.Add(this.olaANSI);
            this.ogbFormateFile.Controls.Add(this.orbWindows874);
            this.ogbFormateFile.Controls.Add(this.orbUTF8);
            this.ogbFormateFile.Location = new System.Drawing.Point(17, 486);
            this.ogbFormateFile.Name = "ogbFormateFile";
            this.ogbFormateFile.Size = new System.Drawing.Size(356, 30);
            this.ogbFormateFile.TabIndex = 31;
            this.ogbFormateFile.TabStop = false;
            this.ogbFormateFile.Text = "FormateFile ";
            // 
            // olaANSI
            // 
            this.olaANSI.AutoSize = true;
            this.olaANSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaANSI.Location = new System.Drawing.Point(274, 9);
            this.olaANSI.Name = "olaANSI";
            this.olaANSI.Size = new System.Drawing.Size(42, 15);
            this.olaANSI.TabIndex = 11;
            this.olaANSI.Text = "(ANSI)";
            // 
            // orbWindows874
            // 
            this.orbWindows874.AutoSize = true;
            this.orbWindows874.Location = new System.Drawing.Point(187, 9);
            this.orbWindows874.Name = "orbWindows874";
            this.orbWindows874.Size = new System.Drawing.Size(90, 17);
            this.orbWindows874.TabIndex = 3;
            this.orbWindows874.TabStop = true;
            this.orbWindows874.Text = "Windows-874";
            this.orbWindows874.UseVisualStyleBackColor = true;
            // 
            // orbUTF8
            // 
            this.orbUTF8.AutoSize = true;
            this.orbUTF8.Location = new System.Drawing.Point(112, 9);
            this.orbUTF8.Name = "orbUTF8";
            this.orbUTF8.Size = new System.Drawing.Size(55, 17);
            this.orbUTF8.TabIndex = 2;
            this.orbUTF8.TabStop = true;
            this.orbUTF8.Text = "UTF-8";
            this.orbUTF8.UseVisualStyleBackColor = true;
            // 
            // wSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ocmClose;
            this.ClientSize = new System.Drawing.Size(522, 575);
            this.ControlBox = false;
            this.Controls.Add(this.ogbFormateFile);
            this.Controls.Add(this.olaBrand);
            this.Controls.Add(this.ogbConfigDb);
            this.Controls.Add(this.ogbNameAndPathConfig);
            this.Controls.Add(this.ocmExportPath);
            this.Controls.Add(this.otbExportPath);
            this.Controls.Add(this.olaExportPath);
            this.Controls.Add(this.ocmClose);
            this.Controls.Add(this.ocmSaveSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.wSetting_Load);
            this.ogbNameAndPathConfig.ResumeLayout(false);
            this.ogbNo4.ResumeLayout(false);
            this.ogbNo4.PerformLayout();
            this.ogbNo2.ResumeLayout(false);
            this.ogbNo2.PerformLayout();
            this.ogbNo3.ResumeLayout(false);
            this.ogbNo3.PerformLayout();
            this.ogbNo1.ResumeLayout(false);
            this.ogbNo1.PerformLayout();
            this.ogbConfigDb.ResumeLayout(false);
            this.ogbConfigDb.PerformLayout();
            this.ogbFormateFile.ResumeLayout(false);
            this.ogbFormateFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ocmExportPath;
        private System.Windows.Forms.TextBox otbExportPath;
        private System.Windows.Forms.Label olaExportPath;
        private System.Windows.Forms.Label olaDbName;
        private System.Windows.Forms.Label olaUserPassword;
        private System.Windows.Forms.Label olaUserName;
        private System.Windows.Forms.Label olaDbLocation;
        private System.Windows.Forms.Button ocmClose;
        private System.Windows.Forms.Button ocmSaveSetting;
        private System.Windows.Forms.Button olaRefreshDbName;
        public System.Windows.Forms.TextBox otbUserPassword;
        public System.Windows.Forms.TextBox otbUserName;
        public System.Windows.Forms.TextBox otbDbLocation;
        private System.Windows.Forms.GroupBox ogbNameAndPathConfig;
        private System.Windows.Forms.TextBox otbFileName4;
        private System.Windows.Forms.TextBox otbFileName3;
        private System.Windows.Forms.TextBox otbFileName2;
        private System.Windows.Forms.TextBox otbFileName1;
        private System.Windows.Forms.Label olaFileName4;
        private System.Windows.Forms.Label olaFileName3;
        private System.Windows.Forms.Label olaFileName2;
        private System.Windows.Forms.Label olaFileName1;
        private System.ComponentModel.BackgroundWorker oBackgroundWorker;
        private System.Windows.Forms.ComboBox ocbDbName;
        private System.Windows.Forms.GroupBox ogbNo4;
        private System.Windows.Forms.GroupBox ogbNo2;
        private System.Windows.Forms.GroupBox ogbNo3;
        private System.Windows.Forms.GroupBox ogbNo1;
        private System.Windows.Forms.Label olaFileSQL1;
        private System.Windows.Forms.Button ocmFileSQL1;
        private System.Windows.Forms.Label olaFileSQL4;
        private System.Windows.Forms.Button ocmFileSQL4;
        private System.Windows.Forms.Label olaFileSQL2;
        private System.Windows.Forms.Button ocmFileSQL2;
        private System.Windows.Forms.Label olaFileSQL3;
        private System.Windows.Forms.Button ocmFileSQL3;
        private System.Windows.Forms.TextBox otbPathSQL4;
        private System.Windows.Forms.TextBox otbPathSQL2;
        private System.Windows.Forms.TextBox otbPathSQL3;
        private System.Windows.Forms.TextBox otbPathSQL1;
        private System.Windows.Forms.GroupBox ogbConfigDb;
        private System.Windows.Forms.Label olaBrand;
        private System.Windows.Forms.GroupBox ogbFormateFile;
        private System.Windows.Forms.RadioButton orbWindows874;
        private System.Windows.Forms.RadioButton orbUTF8;
        private System.Windows.Forms.Label olaANSI;
    }
}