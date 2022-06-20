using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class Product
    {
        public string ID_Product { get; set; }
        public string NameProduct { get; set; }
        public string Category { get; set; }
        public int QuantitySold { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

        public Product()
        {

        }

        public Product(string ID_Product, string nameProduct, string category, 
                            int quantitySold, int price, string image)
        {
            this.ID_Product = ID_Product;
            NameProduct = nameProduct;
            Category = category;
            QuantitySold = quantitySold;
            Price = price;
            Image = image;
        }
    }
}
