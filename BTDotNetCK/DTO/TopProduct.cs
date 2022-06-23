using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class TopProduct
    {
        public string NameProduct { get; set; }
        public int QuantitySold { get; set; }

        public TopProduct()
        {

        }

        public TopProduct(string nameProduct, int quantitySold)
        {
            NameProduct = nameProduct;
            QuantitySold = quantitySold;
        }
    }
}
