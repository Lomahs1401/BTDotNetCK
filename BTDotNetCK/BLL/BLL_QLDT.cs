using BTDotNetCK.DAL;
using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
    class BLL_QLDT
    {
        private static BLL_QLDT _Instance;
        public static BLL_QLDT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLDT();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLDT()
        {

        }

        public int GetNumCustomers()
        {
            return DAL_QLDT.Instance.GetNumCustomers();
        }

        public int GetNumCategoryProduct()
        {
            return DAL_QLDT.Instance.GetNumCategoryProduct();
        }

        public int GetNumQuantitySold()
        {
            return DAL_QLDT.Instance.GetNumQuantitySold();
        }

        public int GetNumOrders()
        {
            return DAL_QLDT.Instance.GetNumCategoryProduct();
        }

        public List<Revenue> GetListRevenues(DateTime startDate, DateTime endDate)
        {
            return DAL_QLDT.Instance.GetListRevenues(startDate, endDate);
        }

        public List<TopProduct> GetTopProducts(DateTime startDate, DateTime endDate)
        {
            return DAL_QLDT.Instance.GetTopProducts(startDate, endDate);
        }

        public List<TopProduct> GetUnderstockProduct(DateTime startDate, DateTime endDate)
        {
            return DAL_QLDT.Instance.GetUnderstockProduct(startDate, endDate);
        }
    }
}
