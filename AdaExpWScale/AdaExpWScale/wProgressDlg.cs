using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdaExpWScale
{
    public partial class wProgressDlg : Form
    {
        private int nW_DigStatus;
        public wProgressDlg(int pnDigStatus)
        {
            nW_DigStatus = pnDigStatus;
            InitializeComponent();
        }

        private void wProgressDlg_Load(object sender, EventArgs e)
        {
            try
            {
                if (nW_DigStatus == 0)
                {
                    //กำหนดรูปแบบของฟอร์มเป็นแบบ none
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    //รูปแบบของ progressBar ให้เป็นแบบ Marquee(วิ่งไปมา)
                    this.opgStatus.Style = ProgressBarStyle.Marquee;
                    olaProgress.Hide();
                    ocmStop.Hide();
                    BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : wProgressDlg_Load // " + oEx.Message);
            }
        }

        private void ocmStop_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                if (W_SEToStopProgress != null)
                {
                    W_SEToStopProgress(sender, e);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmExit_Click // " + oEx.Message);
            }
        }
        // Update Progress Number
        public string W_SETtMessage
        {
            set { this.olaProgress.Text = value; }
        }

        // Update Progress Status
        public int W_SETnProgressValue
        {
            set { this.opgStatus.Value = value; }
        }

        // Stop Event
        public EventHandler W_SEToStopProgress;

    }
}
