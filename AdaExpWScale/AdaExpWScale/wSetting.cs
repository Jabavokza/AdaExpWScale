using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AdaExpWScale
{
    public partial class wSetting : Form
    {
        wProgressDlg oW_ProgressDlg;
        wMain oW_Main;
        public wSetting(wMain poMain)
        {
            oW_Main = poMain;
            InitializeComponent();
            W_SETxDefaultFormateFile();
        }

        private void wSetting_Load(object sender, EventArgs e)
        {
            try
            {
                oBackgroundWorker.WorkerReportsProgress = true;
                oBackgroundWorker.WorkerSupportsCancellation = true;
                W_SETxTextBoxFromXML();
            }
            catch (Exception oEx)
            {
                // MessageBox.Show("wSetting : wSetting_Load // " + oEx.Message);
            }
        }
        private void ocmSaveSetting_Click(object sender, EventArgs e)
        {
            XmlDocument oXmlDoc = new XmlDocument();
            XmlNode oRootNode;
            XmlNode oDbLocation;
            XmlNode oDbName;
            XmlNode oUser;
            XmlNode oPassword;
            XmlNode oPathFile;
            XmlNode oFileName1, oFileName2, oFileName3, oFileName4;
            XmlNode oPathSQL1, oPathSQL2, oPathSQL3, oPathSQL4;
            XmlNode oUserLogin, oPwdLogin;
            XmlNode oFormateFile;
            string tSavePath = "AdaDbconfig.xml";

            try
            {
                oRootNode = oXmlDoc.CreateElement("Config"); //ส่วน root node
                oXmlDoc.AppendChild(oRootNode);

                oDbLocation = oXmlDoc.CreateElement("DbLocation"); // child node
                oDbLocation.InnerText = otbDbLocation.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oDbLocation);

                oUser = oXmlDoc.CreateElement("User"); // child node
                oUser.InnerText = otbUserName.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oUser);

                oPassword = oXmlDoc.CreateElement("Password"); // child node
                oPassword.InnerText = otbUserPassword.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oPassword);

                oDbName = oXmlDoc.CreateElement("DbName"); // child node
                oDbName.InnerText = ocbDbName.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oDbName);

                oFileName1 = oXmlDoc.CreateElement("FileName1"); // child node
                oFileName1.InnerText = otbFileName1.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oFileName1);

                oFileName2 = oXmlDoc.CreateElement("FileName2"); // child node
                oFileName2.InnerText = otbFileName2.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oFileName2);

                oFileName3 = oXmlDoc.CreateElement("FileName3"); // child node
                oFileName3.InnerText = otbFileName3.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oFileName3);

                oFileName4 = oXmlDoc.CreateElement("FileName4"); // child node
                oFileName4.InnerText = otbFileName4.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oFileName4);

                oPathSQL1 = oXmlDoc.CreateElement("PathSQL1"); // child node
                oPathSQL1.InnerText = otbPathSQL1.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oPathSQL1);

                oPathSQL2 = oXmlDoc.CreateElement("PathSQL2"); // child node
                oPathSQL2.InnerText = otbPathSQL2.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oPathSQL2);

                oPathSQL3 = oXmlDoc.CreateElement("PathSQL3"); // child node
                oPathSQL3.InnerText = otbPathSQL3.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oPathSQL3);

                oPathSQL4 = oXmlDoc.CreateElement("PathSQL4"); // child node
                oPathSQL4.InnerText = otbPathSQL4.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oPathSQL4);

                oPathFile = oXmlDoc.CreateElement("PathFile"); // child node
                oPathFile.InnerText = otbExportPath.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oPathFile);

                oUserLogin = oXmlDoc.CreateElement("UserLogin"); // child node
                oUserLogin.InnerText = "009"; //ข้อมูลใน child node
                oRootNode.AppendChild(oUserLogin);

                oPwdLogin = oXmlDoc.CreateElement("PwdLogin"); // child node
                oPwdLogin.InnerText = "009"; //ข้อมูลใน child node
                oRootNode.AppendChild(oPwdLogin);
                oXmlDoc.Save(tSavePath);

                oFormateFile = oXmlDoc.CreateElement("FormateFile"); // child node
                oFormateFile.InnerText = W_SETxFormateFile(); //ข้อมูลใน child node
                oRootNode.AppendChild(oFormateFile);
                oXmlDoc.Save(tSavePath);

                oW_Main.olaFormate.Text = W_SETxFormateFile();
                Close();
                //  MessageBox.Show("Successfull ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : ocmSaveSetting_Click // " + oEx.Message);
            }
        }
        private void ocmClose_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }

            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : ocmClose_Click // " + oEx.Message);
            }
        }
        private void ocmExportPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog oPathFile = new FolderBrowserDialog();

                if (oPathFile.ShowDialog() == DialogResult.OK)
                {
                    otbExportPath.Text = oPathFile.SelectedPath.ToString();
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : ocmExportPath_Click // " + oEx.Message);
            }
        }
        private void olaRefreshDbName_Click(object sender, EventArgs e)
        {
            int nDigStatus = 0;
            try
            {
                if (otbDbLocation.Text == "")
                {
                    otbDbLocation.Focus();
                    return;
                }
                if (otbUserName.Text == "")
                {
                    otbUserName.Focus();
                    return;
                }
                if (otbUserPassword.Text == "")
                {
                    otbUserPassword.Focus();
                    return;
                }

                if (oBackgroundWorker.IsBusy != true)
                {
                    // Start the asynchronous operation.
                    oBackgroundWorker.RunWorkerAsync();
                    // New Dialog
                    oW_ProgressDlg = new wProgressDlg(nDigStatus);
                    oW_ProgressDlg.ShowDialog();
                }

                ocbDbName.DataSource = cCNSP.SP_GEToDbName(otbDbLocation.Text, otbUserName.Text, otbUserPassword.Text);
                ocbDbName.DisplayMember = "NAME";
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : olaRefresh_Click // " + oEx.Message);
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker oWorker = sender as BackgroundWorker;
            try
            {
                for (int nI = 1; nI <= 50; nI++)
                {
                    System.Threading.Thread.Sleep(10);
                    oWorker.ReportProgress(nI);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : BackgroundWorker_DoWork // " + oEx.Message);
            }
        }
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                oW_ProgressDlg.W_SETnProgressValue = e.ProgressPercentage;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : BackgroundWorker_ProgressChanged // " + oEx.Message);
            }
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                oW_ProgressDlg.Close();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : BackgroundWorker_RunWorkerCompleted // " + oEx.Message);
            }
        }

        private void ocmFileSQL1_Click(object sender, EventArgs e)
        {
            string tFilePath;
            try
            {
                OpenFileDialog oOpenFileDialog = new OpenFileDialog();
                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tFilePath = oOpenFileDialog.FileName;
                    otbPathSQL1.Text = Path.GetFullPath(tFilePath);

                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : ocmFileSQL1_Click // " + oEx.Message);
            }

        }
        private void ocmFileSQL2_Click(object sender, EventArgs e)
        {
            string tFilePath;
            try
            {
                OpenFileDialog oOpenFileDialog = new OpenFileDialog();
                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tFilePath = oOpenFileDialog.FileName;
                    otbPathSQL2.Text = Path.GetFullPath(tFilePath);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : ocmFileSQL2_Click // " + oEx.Message);
            }
        }
        private void ocmFileSQL3_Click(object sender, EventArgs e)
        {
            string tFilePath;
            try
            {
                OpenFileDialog oOpenFileDialog = new OpenFileDialog();
                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tFilePath = oOpenFileDialog.FileName;
                    otbPathSQL3.Text = Path.GetFullPath(tFilePath);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : ocmFileSQL3_Click // " + oEx.Message);
            }
        }
        private void ocmFileSQL4_Click(object sender, EventArgs e)
        {
            string tFilePath;
            try
            {
                OpenFileDialog oOpenFileDialog = new OpenFileDialog();
                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tFilePath = oOpenFileDialog.FileName;
                    otbPathSQL4.Text = Path.GetFullPath(tFilePath);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : ocmFileSQL4_Click // " + oEx.Message);
            }
        }

        private void W_SETxTextBoxFromXML()
        {
            try
            {
                otbDbLocation.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["DbLocation"].ToString();
                otbUserName.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["User"].ToString();
                otbUserPassword.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["Password"].ToString();
                ocbDbName.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["DbName"].ToString();
                otbExportPath.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["PathFile"].ToString();
                otbFileName1.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["FileName1"].ToString();
                otbFileName2.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["FileName2"].ToString();
                otbFileName3.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["FileName3"].ToString();
                otbFileName4.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["FileName4"].ToString();
                otbPathSQL1.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["PathSQL1"].ToString();
                otbPathSQL2.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["PathSQL2"].ToString();
                otbPathSQL3.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["PathSQL3"].ToString();
                otbPathSQL4.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["PathSQL4"].ToString();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : W_SETxTextBoxFromXML // " + oEx.Message);
            }
        }
        private string W_SETxFormateFile()
        {
            try
            {
                string tFormateFile;

                if (orbUTF8.Checked == true)
                {
                    tFormateFile = "UTF-8";
                    return tFormateFile;
                }
                else if (orbWindows874.Checked == true)
                {
                    tFormateFile = "Windows-874 (ANSI)";
                    return tFormateFile;
                }
                return "";
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : W_SETxFormateFile ///"+oEx.Message);
                return null;
            }
          
        }

        private void W_SETxDefaultFormateFile()
        {
            try
            {

               var tFormateFile = cCNSP.SP_GEToDbConfigXml().Rows[0]["FormateFile"].ToString();
                if (tFormateFile.Equals("UTF-8"))
                {
                    orbUTF8.Checked = true;
                }
                else if (tFormateFile.Equals("Windows-874 (ANSI)"))
                {
                    orbWindows874.Checked = true;
                }            
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : W_SETxDefault ///" + oEx.Message);
            }

        }

    }
}
