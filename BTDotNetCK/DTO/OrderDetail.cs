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
        public int Quantity { get; set; }
        public int Amount { get; set; }

        public OrderDetail()
        {

        }

        public OrderDetail(string ID_Order, string ID_Product, int quantity, int amount)
        {
            this.ID_Order = ID_Order;
            this.ID_Product = ID_Product;
            Quantity = quantity;
            Amount = amount;
        }
    }
}
