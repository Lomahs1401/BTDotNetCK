using BTDotNetCK.DAL;
using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
    class BLL_QLBH
    {
        private static BLL_QLBH _Instance;
        public static BLL_QLBH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLBH();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLBH()
        {

        }

        public List<Product> GetProducts()
        {
            return DAL_QLBH.Instance.GetListProducts();
        }
        
        public Product GetProductByID(string ID_Product)
        {
            return DAL_QLBH.Instance.GetProductByID(ID_Product);
        }
    }
}
