using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class Order
    {
        public string ID_Order { get; set; }
        public DateTime OrderDate { get; set; }
        public double Discount { get; set; }
        public int Total { get; set; }
        public string ID_Staff { get; set; }
        public string ID_Customer { get; set; }
        public string ID_Table { get; set; }

        public Order()
        {

        }

        public Order(string ID_Order, DateTime orderDate, double discount, int total, string ID_Staff, string ID_Customer, string ID_Table)
        {
            this.ID_Order = ID_Order;
            OrderDate = orderDate;
            Discount = discount;
            Total = total;
            this.ID_Staff = ID_Staff;
            this.ID_Customer = ID_Customer;
            this.ID_Table = ID_Table;
        }
    }
}
