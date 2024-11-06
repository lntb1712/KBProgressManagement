using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.DataAccess.Excel;
using DevExpress.SpreadsheetSource;
using KBProgressManagement.DTO;

namespace KBProgressManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string ConnectionString = "Data Source=" + SQLConfig.ServerName + ";Initial Catalog=" + SQLConfig.DBName + ";User ID=" + SQLConfig.LoginName + ";Password=" + SQLConfig.Password;

        public static bool ReadConfig()
        {
            try
            {
                String path = Application.StartupPath + "/SQL.ini";
                string line = System.IO.File.ReadAllLines(path)[0];
                String[] arr = line.Split(',');
                SQLConfig.ServerName = arr[0];
                SQLConfig.DBName = arr[1];
                SQLConfig.LoginName = arr[2];
                SQLConfig.Password = arr[3];
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool WriteConfig(string ServerName, string DBName, string LoginName, string Password)
        {
            try
            {
                String path = Application.StartupPath + "/SQL.ini";
                System.IO.File.WriteAllText(path, ServerName + "," + DBName + "," + LoginName + "," + Password);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');

                    int i = 0;

                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);

                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');

                    int i = 0;

                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);

                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');

                    int i = 0;

                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);

                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public DataTable ToDataTable(string path)
        {
            ExcelDataSource excel = new ExcelDataSource();
            excel.FileName = path;
            ExcelWorksheetSettings excelWorksheetSettings = new ExcelWorksheetSettings(GetWorkSheetNameByIndex(0, path));
            excel.SourceOptions = new ExcelSourceOptions(excelWorksheetSettings);
            excel.SourceOptions.SkipEmptyRows = true;
            excel.SourceOptions.UseFirstRowAsHeader = true;
            excel.Fill();


            IList list = ((IListSource)excel).GetList();
            DevExpress.DataAccess.Native.Excel.DataView dataView = (DevExpress.DataAccess.Native.Excel.DataView)list;
            List<PropertyDescriptor> props = dataView.Columns.ToList<PropertyDescriptor>();
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (DevExpress.DataAccess.Native.Excel.ViewRow item in list)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public string GetWorkSheetNameByIndex(int p, string path)
        {
            string worksheetName = "";
            using (ISpreadsheetSource spreadsheetSource = SpreadsheetSourceFactory.CreateSource(path))
            {
                IWorksheetCollection worksheetCollection = spreadsheetSource.Worksheets;
                worksheetName = worksheetCollection[p].Name;
            }
            return worksheetName;
        }
    }
}
