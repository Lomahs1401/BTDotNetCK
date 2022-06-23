using BTDotNetCK.DAL;
using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
    class BLL_QLHD
    {
        private static BLL_QLHD _Instance;
        public static BLL_QLHD Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLHD();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLHD()
        {

        }

        public string GetLastID_Order()
        {
            return DAL_QLHD.Instance.GetLastID_Order();
        }

        public bool AddOrder(Order order)
        {
            return DAL_QLHD.Instance.AddOrder(order);
        }

        public bool AddOrderDetail(OrderDetail orderDetail)
        {
            return DAL_QLHD.Instance.AddOrderDetail(orderDetail);
        }

        public List<CBB_TableItem> GetCBB_TableItems()
        {
            return DAL_QLHD.Instance.GetCBB_TableItems();
        }

        public string[] ShowOrderInfo(string ID_Order)
        {
            return DAL_QLHD.Instance.ShowOrderInfo(ID_Order);
        }

        public string[][] ShowOrderTable(string ID_Order)
        {
            return DAL_QLHD.Instance.ShowOrderTable(ID_Order);
        }
    }
}
