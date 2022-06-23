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
    class DAL_QLDT
    {
        private static DAL_QLDT _Instance;
        public static DAL_QLDT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLDT();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLDT()
        {

        }

        public int GetNumCustomers()
        {
            string queryGetNumberCustomer = "GetTotalCustomer";
            DataTable totalCustomer = DataProvider.Instance.GetRecords(queryGetNumberCustomer);
            return Convert.ToInt32(totalCustomer.Rows[0]["TongKhachHang"].ToString());
        }

        public int GetNumCategoryProduct()
        {
            string queryGetNumberCategoryProduct = "GetTotalCategory";
            DataTable totalCategory = DataProvider.Instance.GetRecords(queryGetNumberCategoryProduct);
            return Convert.ToInt32(totalCategory.Rows[0]["TongMatHang"].ToString());
        }

        public int GetNumQuantitySold()
        {
            string queryGetNumberQuantitySold = "GetNumQuantitySold";
            DataTable quantitySold = DataProvider.Instance.GetRecords(queryGetNumberQuantitySold);
            return Convert.ToInt32(quantitySold.Rows[0]["SoLuongDaBan"].ToString());
        }

        public int GetNumOrders()
        {
            string queryGetNumberOrders = "GetNumOrders";
            DataTable numOrders = DataProvider.Instance.GetRecords(queryGetNumberOrders);
            return Convert.ToInt32(numOrders.Rows[0]["TongHoaDon"].ToString());
        }

        public List<Revenue> GetListRevenues(DateTime startDate, DateTime endDate)
        {
            List<Revenue> listRevenues = new List<Revenue>();
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetRevenues",
                    Connection = connection
                };
                command.Parameters.AddWithValue("@TimeStart", startDate);
                command.Parameters.AddWithValue("@TimeEnd", endDate);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                connection.Open();
                sqlDataAdapter.Fill(data);
                connection.Close();

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow r in data.Rows)
                    {
                        listRevenues.Add(GetRevenue(r));
                    }
                    return listRevenues;
                }
                else
                    return null;
            }
        }

        public List<TopProduct> GetTopProducts(DateTime startDate, DateTime endDate)
        {
            List<TopProduct> listTopProducts = new List<TopProduct>();
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetTopProducts",
                    Connection = connection
                };
                command.Parameters.AddWithValue("@TimeStart", startDate);
                command.Parameters.AddWithValue("@TimeEnd", endDate);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                connection.Open();
                sqlDataAdapter.Fill(data);
                connection.Close();

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow r in data.Rows)
                    {
                        listTopProducts.Add(GetTopProduct(r));
                    }
                    return listTopProducts;
                }
                else
                    return null;
            }
        }

        public List<TopProduct> GetUnderstockProduct(DateTime startDate, DateTime endDate)
        {
            List<TopProduct> listTopProducts = new List<TopProduct>();
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetUnderstockProduct",
                    Connection = connection
                };
                command.Parameters.AddWithValue("@TimeStart", startDate);
                command.Parameters.AddWithValue("@TimeEnd", endDate);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                connection.Open();
                sqlDataAdapter.Fill(data);
                connection.Close();

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow r in data.Rows)
                    {
                        listTopProducts.Add(GetTopProduct(r));
                    }
                    return listTopProducts;
                }
                else
                    return null;
            }
        }

        public Revenue GetRevenue(DataRow r)
        {
            return new Revenue
            {
                OrderDate = (DateTime)r["NgayTao"],
                TotalAmount = Convert.ToInt32(r["TongDoanhThu"].ToString())
            };
        }

        public TopProduct GetTopProduct(DataRow r)
        {
            return new TopProduct
            {
                NameProduct =  r["TenHangHoa"].ToString(),
                QuantitySold = Convert.ToInt32(r["SoLuongDaBan"].ToString())
            };
        }
    }
}
