using BTDotNetCK.DAL;
using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
    // Quản lý bán hàng
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

        public List<Product> GetProductsByName(string nameProduct)
        {
            return DAL_QLBH.Instance.GetProductsByName(nameProduct);
        }

        public List<Product> SortProductsByPriceAscending()
        {
            return DAL_QLBH.Instance.SortProductsByPriceAscending();
        }

        public List<Product> SortProductsByPriceDescending()
        {
            return DAL_QLBH.Instance.SortProductsByPriceDescending();
        }


        public Product GetProductByID(string ID_Product)
        {
            return DAL_QLBH.Instance.GetProductByID(ID_Product);
        }

        public string GetLastID()
        {
            return DAL_QLBH.Instance.GetLastID();
        }

        public int GetNumberTotalCategory()
        {
            return DAL_QLBH.Instance.GetNumberTotalCategory();
        }

        public int GetNumberTotalFoodCategory()
        {
            return DAL_QLBH.Instance.GetNumberTotalFoodCategory();
        }

        public int GetNumberTotalDrinkCategory()
        {
            return DAL_QLBH.Instance.GetNumberTotalDrinkCategory();
        }

        public bool AddProduct(Product product)
        {
            if (DAL_QLBH.Instance.AddProduct(product))
                return true;
            else
                return false;
        }

        public bool UpdateProduct(Product product)
        {
            if (DAL_QLBH.Instance.UpdateProduct(product))
                return true;
            else
                return false;
        }

        public bool DeleteProduct(string ID_Product)
        {
            if (DAL_QLBH.Instance.DeleteProduct(ID_Product))
                return true;
            else
                return false;
        }

        public bool ValidateNameHang(string nameHang)
        {
            if (nameHang == "")
                return false;
            else
                return true;
        }

        public bool ValidateCategory(object category)
        {
            if (category == null)
                return false;
            else
                return true;
        }


        public bool ValidatePrice(string price)
        {
            if (price == "")
                return false;
            else if (Convert.ToInt32(price) < 0)
                return false;
            else
                return true;
        }
    }
}
