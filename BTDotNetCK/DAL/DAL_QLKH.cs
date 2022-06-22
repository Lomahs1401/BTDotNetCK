using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DAL
{
    class DAL_QLKH
    {
        private static DAL_QLKH _Instance;
        public static DAL_QLKH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLKH();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLKH()
        {

        }

        public List<Customer> GetListCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string queryGetAllCustomers = "GetAllCustomer";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllCustomers);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow r in data.Rows)
                {
                    customers.Add(GetCustomer(r));
                }
                return customers;
            }
            else
                return null;
        }

        public List<Customer> GetCustomersByName(string nameCustomer)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                List<Customer> customers = new List<Customer>();
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetCustomersWithName",
                    Connection = connection
                };
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command.Parameters.AddWithValue("@NAME", nameCustomer);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                connection.Close();

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow r in data.Rows)
                    {
                        customers.Add(GetCustomer(r));
                    }
                    return customers;
                }
                else
                    return null;

            }
            
        }

        public Customer GetCustomerByID(string ID_Customer)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "LayKhachHangTheoID",
                    Connection = connection
                };
                command.Parameters.AddWithValue("@ID_KhachHang", ID_Customer);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                connection.Open();
                sqlDataAdapter.Fill(data);
                connection.Close();

                if (data.Rows.Count > 0)
                    return GetCustomer(data.Rows[0]);
                else
                    return null;
            }
        }

        public Customer GetCustomerByPhone(string phone)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetCustomersWithPhone",
                    Connection = connection
                };
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.Parameters.AddWithValue("@Phone", phone);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                if (data.Rows.Count > 0)
                    return GetCustomer(data.Rows[0]);
                else
                    return null;
            }
            
        }

        public int GetNumberTotalCustomer()
        {
            string queryGetNumberCustomer = "GetTotalCustomer";
            DataTable totalCustomer = DataProvider.Instance.GetRecords(queryGetNumberCustomer);
            return Convert.ToInt32(totalCustomer.Rows[0]["TongKhachHang"].ToString());
        }

        public int GetNumberTotalMaleCustomer()
        {
            string queryGetNumberMaleCustomer = @"GetTotalMaleCustomer";
            DataTable totalMaleCustomer = DataProvider.Instance.GetRecords(queryGetNumberMaleCustomer);
            return Convert.ToInt32(totalMaleCustomer.Rows[0]["TongKhachHangNam"].ToString());
        }

        public int GetNumberTotalFemaleCustomer()
        {
            string queryGetNumberFemaleCustomer = @"GetTotalFemaleCustomer";
            DataTable totalFemaleCustomer = DataProvider.Instance.GetRecords(queryGetNumberFemaleCustomer);
            return Convert.ToInt32(totalFemaleCustomer.Rows[0]["TongKhachHangNu"].ToString());
        }

        public Customer GetCustomer(DataRow r)
        {
            return new Customer
            {
                ID_Customer = r["ID_KhachHang"].ToString(),
                NameCustomer = r["HoVaTen"].ToString(),
                Gender = r["GioiTinh"].ToString(),
                Phone = r["SDT"].ToString(),
                Address = r["DiaChi"].ToString(),
            };
        }
    }
}
