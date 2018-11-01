using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AdaExpWScale
{
    public static class cCNSP
    {

        public static DataTable SP_GEToDbTbl(string ptSQL)
        {
            SqlConnection oDbCon;
            SqlDataAdapter oDbAdt;
            DataTable oDbTbl;
            try
            {
                oDbCon = new SqlConnection();
                oDbTbl = new DataTable();
                oDbCon.ConnectionString = SP_SETxConStr();
                oDbCon.Open();
                oDbAdt = new SqlDataAdapter(ptSQL, oDbCon);
                oDbAdt.Fill(oDbTbl);
                oDbCon.Close();

                return oDbTbl;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("cCNSP : SP_GEToDbTbl // " + oEx.Message);
                return null;
            }
            finally
            {
                oDbCon = null;
                oDbAdt = null;
                oDbTbl = null;
            }
        }

        public static DataTable SP_GEToDbConfigXml()
        {
            XmlReader oXmlFile;
            DataSet oDs = new DataSet();
            DataTable oDbTbl = new DataTable();
            try
            {
                oXmlFile = XmlReader.Create(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\AdaDbconfig.xml", new XmlReaderSettings());
                oDs.ReadXml(oXmlFile);
                oDbTbl = oDs.Tables[0];
                oXmlFile.Close();
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                return null;
            }
            finally
            {
                oXmlFile = null;
                oDs = null;
                oDbTbl = null;
            }
        }

        public static DataTable SP_GEToStaOpenAppConfigXml()
        {
            XmlReader oXmlFile;
            DataSet oDs = new DataSet();
            DataTable oDbTbl = new DataTable();
            try
            {
                oXmlFile = XmlReader.Create(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\AdaStaOpenAppconfig.xml", new XmlReaderSettings());
                oDs.ReadXml(oXmlFile);
                oDbTbl = oDs.Tables[0];
                oXmlFile.Close();
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("cCNSP : SP_GEToStaOpenAppConfigXml //" + oEx.Message);
                return null;
            }
            finally
            {
                oXmlFile = null;
                oDs = null;
                oDbTbl = null;
            }
        }

        public static string SP_SETxConStr()
        {
            StringBuilder oConStr = new StringBuilder();
            try
            {
                SP_GEToDbConfigXml();
                oConStr.Append("Data Source= '" + SP_GEToDbConfigXml().Rows[0]["DbLocation"].ToString() + "';");
                oConStr.Append("Initial Catalog= '" + SP_GEToDbConfigXml().Rows[0]["DbName"].ToString() + "';");
                oConStr.Append("User ID= '" + SP_GEToDbConfigXml().Rows[0]["User"].ToString() + "';");
                oConStr.Append("Password= '" + SP_GEToDbConfigXml().Rows[0]["Password"].ToString() + "'");
                return oConStr.ToString();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("cCNSP : SP_SETxConStr //" + oEx.Message);

                return null;
            }
            finally
            {
                oConStr = null;
            }
        }

        public static DataTable SP_GEToDbName(string ptDbLocation, string ptUserName, string ptUserPassword)
        {
            SqlConnection oDbCon;
            SqlDataAdapter oDbAdt;
            DataTable oDbTbl;
            StringBuilder oStrCon;
            StringBuilder oStrSql;
            try
            {
                oStrCon = new StringBuilder();
                oDbCon = new SqlConnection();
                oDbTbl = new DataTable();
                oStrSql = new StringBuilder();
                oStrCon.AppendLine("Data Source='" + ptDbLocation + "';");
                oStrCon.AppendLine("User ID='" + ptUserName + "';");
                oStrCon.AppendLine("Password ='" + ptUserPassword + "'");
                oStrSql.AppendLine("SELECT NAME");
                oStrSql.AppendLine("FROM sys.databases");
                oDbCon.ConnectionString = oStrCon.ToString();
                oDbCon.Open();
                oDbAdt = new SqlDataAdapter(oStrSql.ToString(), oDbCon);
                oDbAdt.Fill(oDbTbl);
                oDbCon.Close();
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("cCNSP : SP_GEToDbCon // " + oEx.Message);
                return null;
            }
            finally
            {
                oDbCon = null;
                oDbAdt = null;
              
            }
        }

    }
}
