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
    public partial class wMain : Form
    {
        private wProgressDlg oW_ProgressDlg;

        public wMain()
        {

            InitializeComponent();

        }

        private void wMain_Load(object sender, EventArgs e)
        {
            try
            {
                oBackgroundWorker.WorkerReportsProgress = true;
                oBackgroundWorker.WorkerSupportsCancellation = true;
                olaFormate.Text = cCNSP.SP_GEToDbConfigXml().Rows[0]["FormateFile"].ToString();
                if (cCNSP.SP_GEToStaOpenAppConfigXml().Rows[0]["StaOpenApp"].ToString() == "1")
                {
                    W_GETxExport("AutoMode");
                    WindowState = FormWindowState.Minimized;
                }
                W_SETxStaOpenApp();
            }
            catch (Exception oEx)
            {
              // MessageBox.Show("wMain : wMain_Load // " + oEx.Message);
            }
        }

        private void ocmExport_Click(object sender, EventArgs e)
        {

            try
            {
                W_GETxExport("ManulMode");
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmExport_Click // " + oEx.Message);
            }
        }
        private void ocmSetting_Click(object sender, EventArgs e)
        {
            wSetting oSetting = new wSetting(this);
            try
            {
                oSetting.ShowDialog();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmSetting_Click // " + oEx.Message);
            }
        }

        private void ocmExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmExit_Click // " + oEx.Message);
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker oWorker = sender as BackgroundWorker;
            try
            {
                for (int nI = 1; nI <= 100; nI++)
                {
                    if (oWorker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        switch (nI)
                        {
                            case 10: W_GETxDbToFileName2(); break;
                            case 20: W_GETxDbToFileName3(); break;
                            case 30: W_GETxDbToFileName4(); break;
                            case 70: W_GETxDbToFileName1(); break;

                        }
                        // Perform a time consuming operation and report progress.
                        System.Threading.Thread.Sleep(50); // ปรับตัวเลขให้สอดคล้องกับ Loop ที่จะทำงาน
                        oWorker.ReportProgress(nI);
                    }
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : BackgroundWorker_DoWork // " + oEx.Message);
            }
            finally
            {

            }
        }
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                oW_ProgressDlg.W_SETtMessage = (e.ProgressPercentage.ToString() + "%");
                oW_ProgressDlg.W_SETnProgressValue = e.ProgressPercentage;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : BackgroundWorker_ProgressChanged // " + oEx.Message);
            }
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled == true)
                {
                    MessageBox.Show("Cancelled ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (e.Error != null)
                {
                    MessageBox.Show("Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show("Successfull ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                oW_ProgressDlg.Close();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : BackgroundWorker_RunWorkerCompleted // " + oEx.Message);
            }
        }

        private void wMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : wMain_FormClosing ///" + oEx.Message);

            }
        }

        private void W_SETxFiletxt(DataTable poFileName, string ptFileName)
        {
            string tStr = string.Empty;
            StreamWriter oWriter;
            try
            {
                foreach (DataColumn oColumn in poFileName.Columns)
                {
                    tStr += oColumn.ColumnName + "\t";
                }
                tStr += "\r\n";

                foreach (DataRow oRow in poFileName.Rows)
                {
                    foreach (DataColumn column in poFileName.Columns)
                    {
                        tStr += oRow[column.ColumnName].ToString() + "\t";
                    }
                    tStr += "\r\n";
                }
                try
                {
                    if (cCNSP.SP_GEToDbConfigXml().Rows[0]["FormateFile"].ToString().Equals("UTF-8"))
                    {
                        //oWriter = new StreamWriter(cCNSP.SP_GEToDbConfigXml().Rows[0]["PathFile"] + ptFileName, false, Encoding.UTF8);
                        //oWriter.WriteLine(tStr.ToString());
                        //oWriter.Close();

                        Encoding oTIS = Encoding.GetEncoding("TIS-620");
                        Encoding oWindows = Encoding.GetEncoding(874);
                        byte[] bWindows = oWindows.GetBytes(tStr.ToString());
                        byte[] bTIS = Encoding.Convert(oTIS, oWindows, bWindows);
                        var tSTR = oTIS.GetString(bTIS);
                        oWriter = new StreamWriter(cCNSP.SP_GEToDbConfigXml().Rows[0]["PathFile"] + ptFileName, false);
                        oWriter.WriteLine(tSTR.ToString());
                        oWriter.Close();

                    }
                    else if (cCNSP.SP_GEToDbConfigXml().Rows[0]["FormateFile"].ToString().Equals("Windows-874 (ANSI)"))
                    {

                        oWriter = new StreamWriter(cCNSP.SP_GEToDbConfigXml().Rows[0]["PathFile"] + ptFileName.Replace(".txt", "-ansi.txt"), false, Encoding.GetEncoding(874));
                        oWriter.WriteLine(tStr.ToString());
                        oWriter.Close();
                    }
                }
                catch (Exception oEx)
                {
                    MessageBox.Show("wMain : W_SETxFiletxt ///"+ oEx.Message);
                }
                    
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_SETxFiletxt // " + oEx.Message);
            }
        }

        private void W_GETxExport(string ptOpenMode)
        {
            int nDigStatus = 1;
            try
            {
                if (oBackgroundWorker.IsBusy != true)
                {
                    oBackgroundWorker.RunWorkerAsync();

                    oW_ProgressDlg = new wProgressDlg(nDigStatus);
                    oW_ProgressDlg.W_SEToStopProgress = new EventHandler((s, e1) =>
                    {
                        switch (oW_ProgressDlg.DialogResult)
                        {
                            case DialogResult.Cancel:
                                oBackgroundWorker.CancelAsync();
                                oW_ProgressDlg.Close();
                                break;
                        }
                    });
                    if (ptOpenMode == "AutoMode")
                    {
                        oW_ProgressDlg.Hide();
                    }
                    else
                    {
                        oW_ProgressDlg.Show();
                    }
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_GETxExport // " + oEx.Message);
            }
        }

        private void W_GETxDbToFileName1()
        {
            DataTable oFileName1;
            string tSQL;
            try
            {
                tSQL = File.ReadAllText(cCNSP.SP_GEToDbConfigXml().Rows[0]["PathSQL1"].ToString());
                oFileName1 = cCNSP.SP_GEToDbTbl(tSQL);

                W_SETxFiletxt(oFileName1, "\\" + cCNSP.SP_GEToDbConfigXml().Rows[0]["FileName1"]);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_GETxDbToFileName1 // " + oEx.Message);
            }
        }

        private void W_GETxDbToFileName2()
        {
            DataTable oFileName2;
            string tSQL;
            try
            {
                tSQL = File.ReadAllText(cCNSP.SP_GEToDbConfigXml().Rows[0]["PathSQL2"].ToString());
                oFileName2 = cCNSP.SP_GEToDbTbl(tSQL);

                W_SETxFiletxt(oFileName2, "\\" + cCNSP.SP_GEToDbConfigXml().Rows[0]["FileName2"]);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_GETxDbToFileName2 // " + oEx.Message);
            }
        }

        private void W_GETxDbToFileName3()
        {
            DataTable oFileName3;
            string tSQL;
            try
            {
                tSQL = File.ReadAllText(cCNSP.SP_GEToDbConfigXml().Rows[0]["PathSQL3"].ToString());
                oFileName3 = cCNSP.SP_GEToDbTbl(tSQL);

                W_SETxFiletxt(oFileName3, "\\" + cCNSP.SP_GEToDbConfigXml().Rows[0]["FileName3"]);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_GETxDbToFileName3 // " + oEx.Message);
            }
        }

        private void W_GETxDbToFileName4()
        {
            DataTable oFileName4;
            string tSQL;
            try
            {
                tSQL = File.ReadAllText(cCNSP.SP_GEToDbConfigXml().Rows[0]["PathSQL4"].ToString());
                oFileName4 = cCNSP.SP_GEToDbTbl(tSQL);
                W_SETxFiletxt(oFileName4, "\\" + cCNSP.SP_GEToDbConfigXml().Rows[0]["FileName4"]);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_GETxDbToFileName4 // " + oEx.Message);
            }
        }

        private void W_SETxStaOpenApp()
        {
            XmlDocument oXmlDoc = new XmlDocument();
            XmlNode oRootNode;
            XmlNode oStaOpenApp;
            string tSavePath = "AdaStaOpenAppconfig.xml";
            try
            {
                oRootNode = oXmlDoc.CreateElement("Config"); //ส่วน root node
                oXmlDoc.AppendChild(oRootNode);

                oStaOpenApp = oXmlDoc.CreateElement("StaOpenApp"); // child node
                oStaOpenApp.InnerText = "0"; //ข้อมูลใน child node
                oRootNode.AppendChild(oStaOpenApp);
                oXmlDoc.Save(tSavePath);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_SETxStaOpenApp // " + oEx.Message);
            }
        }

    }
}
