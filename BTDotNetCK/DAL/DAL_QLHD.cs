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
    class DAL_QLHD
    {
        private static int count = 1;
        private static DAL_QLHD _Instance;
        public static DAL_QLHD Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLHD();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLHD()
        {

        }

        public string GetLastID_Order()
        {
            string queryGetLassIDOrder = @"select top 1 ID_HoaDon from HOADON order by ID_HoaDon desc;";
            DataTable lastID = DataProvider.Instance.GetRecords(queryGetLassIDOrder);
            if (lastID.Rows.Count > 0)
                return lastID.Rows[0]["ID_HoaDon"].ToString();
            else
                return null;
        }

        public bool AddOrder(Order order)
        {
            string queryAddNewOrder = @"insert into HOADON (ID_HoaDon, NgayTao, GiamGia, TongTien, ID_QuanLy, ID_KhachHang, ID_Ban) " +
                                    "values ('" + order.ID_Order + "', '" + order.OrderDate + "', '" + order.Discount + "', '" 
                                                + order.Total + "', '" + order.ID_Staff + "', '" + order.ID_Customer + "', '" + order.ID_Table + "')";
            if (DataProvider.Instance.ExecuteDB(queryAddNewOrder) != -1)
                return true;
            else
                return false;
        }

        public bool AddOrderDetail(OrderDetail orderDetail)
        {
            string queryAddNewOrder = @"insert into CHITIETHOADON (ID_HoaDon, ID_HangHoa, SoLuong, ThanhTien) " +
                                    "values ('" + orderDetail.ID_Order + "', '" + orderDetail.ID_Product + "', '" + orderDetail.QuantitySold + "', '"+ orderDetail.TotalAmount + "')";
            if (DataProvider.Instance.ExecuteDB(queryAddNewOrder) != -1)
                return true;
            else
                return false;
        }

        public List<CBB_TableItem> GetCBB_TableItems()
        {
            List<CBB_TableItem> list = new List<CBB_TableItem>();
            string queryGetTable = "select ID_Ban from BAN;";
            DataTable data = DataProvider.Instance.GetRecords(queryGetTable);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow r in data.Rows)
                {
                    list.Add(GetCBB_TableItem(r, count));
                    count++;
                }
                count = 1;
                return list;
            }
            else
                return null;
        }

        public CBB_TableItem GetCBB_TableItem(DataRow r, int count)
        {
            return new CBB_TableItem
            {
                ID_Table = r["ID_Ban"].ToString(),
                Table = "Bàn " + count
            };
        }

        public string[] ShowOrderInfo(string ID_Order)
        {
            string[] result = new string[7];
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SHOW_ORDER_INFOR",
                    Connection = connection
                };
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.Parameters.AddWithValue("@ID_HoaDon", ID_Order);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);

                if (data.Rows.Count > 0)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        result[i] = data.Rows[0][i].ToString();
                    }
                    return result;
                }
                else
                    return null;
            }
        }

        public string[][] ShowOrderTable(string ID_Order)
        {
            
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SHOW_ORDER_TABLE",
                    Connection = connection
                };
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.Parameters.AddWithValue("@ID_HoaDon", ID_Order);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                string[][] result = new string[data.Rows.Count][];
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    result[i] = new string[4];
                }
                if (data.Rows.Count > 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            result[i][j] = data.Rows[i][j].ToString();
                        }
                    }
                    return result;
                }    
                else
                    return null;
            }
        }
    }
}
