using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BTDotNetCK.DAL
{
    class DAL_Login
    {
        private static DAL_Login _Instance;
        public static DAL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Login();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_Login()
        {

        }

        public string CheckLogin(Account account)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "KiemTraDangNhap",
                    Connection = connection
                };
                command.Parameters.AddWithValue("@TenDangNhap", account.UserName);
                command.Parameters.AddWithValue("@MatKhau", account.Password);
                command.Parameters.AddWithValue("@Quyen", account.Role);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                connection.Open();
                sqlDataAdapter.Fill(data);
                connection.Close();
                if (data.Rows.Count == 0)
                    return "Đăng nhập thất bại";
                else
                    return "Đăng nhập thành công";
            }
        }

        public string GetNameStaff(Account account)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetNameStaff",
                    Connection = connection
                };
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.Parameters.AddWithValue("@UserName", account.UserName);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                if (data.Rows.Count > 0)
                    return data.Rows[0]["HoVaTen"].ToString();
                else
                    return null;
            }
        }
    }
}
