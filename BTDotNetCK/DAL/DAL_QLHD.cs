using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DAL
{
    class DAL_QLHD
    {
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
    }
}
