using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdaExpWScale
{
    public partial class wLogin : Form
    {
        public wLogin()
        {
            InitializeComponent();
        }

        private void ocmOk_Click(object sender, EventArgs e)
        {
            string tUser, tPwd;
            wMain oMain = new wMain();
            try
            {
                if (otbUserName.Text == string.Empty)
                {
                    otbUserName.Focus();
                    return;

                }
                if (otbUserPassword.Text == string.Empty)
                {
                    otbUserPassword.Focus();
                    return;
                }

                tUser = cCNSP.SP_GEToDbConfigXml().Rows[0]["UserLogin"].ToString();
                tPwd = cCNSP.SP_GEToDbConfigXml().Rows[0]["PwdLogin"].ToString();

                if (tUser == otbUserName.Text && tPwd == otbUserPassword.Text)
                {
                    //  MessageBox.Show("Successfull", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    oMain.Show();

                }
                else
                {
                    MessageBox.Show("User หรือ Password ผิด", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wLogin : ocmOk_Click // " + oEx.Message);
            }
        }

        private void ocmCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wLogin : ocmCancel_Click // " + oEx.Message);
            }
        }
    }
}
