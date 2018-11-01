using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace AdaExpWScale
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (cCNSP.SP_GEToStaOpenAppConfigXml().Rows[0]["StaOpenApp"].ToString() == "1")
                {
                    Application.Run(new wMain());
                }
                else if(cCNSP.SP_GEToStaOpenAppConfigXml().Rows[0]["StaOpenApp"].ToString() == "0")
                {
                    Application.Run(new wLogin());
                } 
            }
            catch (Exception oEx)
            {

            }    
        }       
    }
}
