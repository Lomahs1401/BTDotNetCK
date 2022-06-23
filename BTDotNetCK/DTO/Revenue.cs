using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class Revenue
    {
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }

        public Revenue()
        {

        }

        public Revenue(DateTime orderDate, int totalAmount)
        {
            OrderDate = orderDate;
            TotalAmount = totalAmount;
        }
    }
}
