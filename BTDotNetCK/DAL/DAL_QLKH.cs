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
            string queryGetAllCustomers = @"select * from KHACHHANG;";
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
            List<Customer> customers = new List<Customer>();
            string queryGetAllCustomersByName = @"select * from KHACHHANG where HoVaTen like N'%" + nameCustomer + "%';";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllCustomersByName);
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
            string queryGetCustomerByPhone = @"select * from KHACHHANG where SDT = '" + phone + "';";
            DataTable data = DataProvider.Instance.GetRecords(queryGetCustomerByPhone);
            if (data.Rows.Count > 0)
                return GetCustomer(data.Rows[0]);
            else
                return null;
        }

        public string GetLastID()
        {
            string queryGetLastIDCustomer = @"select top 1 ID_KhachHang from KHACHHANG order by ID_KhachHang desc;";
            DataTable lastID = DataProvider.Instance.GetRecords(queryGetLastIDCustomer);
            if (lastID.Rows.Count > 0)
                return lastID.Rows[0]["ID_KhachHang"].ToString();
            else
                return null;
        }

        public int GetNumberTotalCustomer()
        {
            string queryGetNumberCustomer = @"select count(ID_KhachHang) as TongKhachHang from KHACHHANG;";
            DataTable totalCustomer = DataProvider.Instance.GetRecords(queryGetNumberCustomer);
            return Convert.ToInt32(totalCustomer.Rows[0]["TongKhachHang"].ToString());
        }

        public int GetNumberTotalMaleCustomer()
        {
            string queryGetNumberMaleCustomer = @"select count(ID_KhachHang) as TongKhachHangNam from KHACHHANG where GioiTinh = N'Nam';";
            DataTable totalMaleCustomer = DataProvider.Instance.GetRecords(queryGetNumberMaleCustomer);
            return Convert.ToInt32(totalMaleCustomer.Rows[0]["TongKhachHangNam"].ToString());
        }

        public int GetNumberTotalFemaleCustomer()
        {
            string queryGetNumberFemaleCustomer = @"select count(ID_KhachHang) as TongKhachHangNu from KHACHHANG where GioiTinh = N'Nữ';";
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

        public bool AddCustomer(Customer customer)
        {
            string queryAddNewCustomer = @"insert into KHACHHANG (ID_KhachHang, HoVaTen, GioiTinh, DiaChi, SDT) " +
            "values ('" + customer.ID_Customer + "', N'" + customer.NameCustomer + "', N'" + customer.Gender + "', N'" + customer.Address + "', '" + customer.Phone + "')";
            if (DataProvider.Instance.ExecuteDB(queryAddNewCustomer) != -1)
                return true;
            else
                return false;
        }
    }
}
