using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class OrderDetail
    {
        public string ID_Order { get; set; }
        public string ID_Product { get; set; }
        public int QuantitySold { get; set; }
        public int TotalAmount { get; set; }

        public OrderDetail()
        {

        }

        public OrderDetail(string ID_Order, string ID_Product, int quantitySold, int totalAmount)
        {
            this.ID_Order = ID_Order;
            this.ID_Product = ID_Product;
            QuantitySold = quantitySold;
            TotalAmount = totalAmount;
        }
    }
}
