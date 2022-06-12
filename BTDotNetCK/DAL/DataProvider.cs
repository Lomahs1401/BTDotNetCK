using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DAL
{
    public class DataProvider
    {
        private static DataProvider _Instance;

        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DataProvider();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DataProvider()
        {

        }

        // Insert, Update, Delete
        public int ExecuteDB(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
                {
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    connection.Open();
                    int result = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    return result;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        // Select, Select with Where clause
        public DataTable GetRecords(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    sqlDataAdapter.Fill(dataTable); // Đổ dữ liệu từ db ra dataTable
                    connection.Close();
                    return dataTable;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
