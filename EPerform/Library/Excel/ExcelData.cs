using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Library.Excel
{
    class ExcelData
    {

        public static ArrayList GetData(string ConfigKey, string SheetName, string ConditionKey, string ConditionValue)
        {
            var fileName = DirectoryPath() + ConfigurationManager.AppSettings[ConfigKey];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);

            using (var connection = new OleDbConnection(con))
            {
                connection.Open();
                var query = string.Format("select * from [" + SheetName + "$] where " + ConditionKey + "='{0}'", ConditionValue);
                OleDbCommand oledbCmd = new OleDbCommand(query, connection);
                OleDbDataReader oledbReader = oledbCmd.ExecuteReader();
                ArrayList list = new ArrayList();
                while (oledbReader.Read())
                {
                    for (int i = 0; i < oledbReader.VisibleFieldCount; i++)
                    {
                        var data = oledbReader[i].ToString();
                        list.Add(data.ToString());
                    }
                }
                connection.Close();
                return list;
            }
        }

        /// <summary>
        /// Get Data from Excel sheet
        /// </summary>
        /// <param name="ConfigKey">Mention the Configurtion Key defined in the App.config file</param>
        /// <param name="SheetName">Excel Sheet Name</param>
        /// /// <returns>List of Values</returns>

        public static ArrayList GetData(string ConfigKey, string SheetName)
        {
            var fileName = DirectoryPath() + ConfigurationManager.AppSettings[ConfigKey];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);

            using (var connection = new OleDbConnection(con))
            {
                connection.Open();
                var query = string.Format("select * from [" + SheetName + "$]");
                OleDbCommand oledbCmd = new OleDbCommand(query, connection);
                OleDbDataReader oledbReader = oledbCmd.ExecuteReader();
                ArrayList list = new ArrayList();
                while (oledbReader.Read())
                {
                    for (int i = 0; i < oledbReader.VisibleFieldCount; i++)
                    {
                        var data = oledbReader[i].ToString();
                        list.Add(data.ToString());
                    }
                }
                connection.Close();
                return list;
            }
        }


        public static DataTable GetData_DataTable(string ConfigKey, string SheetName, string ConditionKey, string ConditionValue)
        {
            var fileName = DirectoryPath() + ConfigurationManager.AppSettings[ConfigKey];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);

            using (var connection = new OleDbConnection(con))
            {
                connection.Open();
                var query = string.Format("select * from [" + SheetName + "$] where " + ConditionKey + "='{0}'", ConditionValue);
                OleDbCommand oledbCmd = new OleDbCommand(query, connection);
                OleDbDataReader oledbReader = oledbCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(oledbReader);
                connection.Close();
                return dt;
            }
        }


        public static DataTable GetData_DataTable(string ConfigKey, string SheetName, string ConditionKey, int ConditionValue)
        {
            var fileName = DirectoryPath() + ConfigurationManager.AppSettings[ConfigKey];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);

            using (var connection = new OleDbConnection(con))
            {
                connection.Open();
                var query = string.Format("select * from [" + SheetName + "$] where " + ConditionKey + "={0}", ConditionValue);
                OleDbCommand oledbCmd = new OleDbCommand(query, connection);
                OleDbDataReader oledbReader = oledbCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(oledbReader);
                connection.Close();
                return dt;
            }
        }

        /// <summary>
        /// Get Data from Excel sheet
        /// </summary>
        /// <param name="ConfigKey">Mention the Configurtion Key defined in the App.config file</param>
        /// <param name="SheetName">Excel Sheet Name</param>
        /// /// <returns>List of Values</returns>
        public static DataTable GetData_DataTable(string ConfigKey, string SheetName)
        {
            var fileName = DirectoryPath() + ConfigurationManager.AppSettings[ConfigKey];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);

            using (var connection = new OleDbConnection(con))
            {
                connection.Open();
                var query = string.Format("select * from [" + SheetName + "$]");
                OleDbCommand oledbCmd = new OleDbCommand(query, connection);
                OleDbDataReader oledbReader = oledbCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(oledbReader);
                connection.Close();
                return dt;
            }
        }

        public static string DirectoryPath()
        {
            string CurrDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dirPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int binIndex = dirPath.IndexOf("bin");
            dirPath = dirPath.Substring(0, binIndex);
            return dirPath;
        }
    }
}


