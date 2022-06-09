using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class Customer
    {
        public string ID_Customer { get; set; }
        public string NameCustomer { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Customer()
        {

        }

        public Customer(string ID_Customer, string nameCustomer, string gender, string phone, string address)
        {
            this.ID_Customer = ID_Customer;
            NameCustomer = nameCustomer;
            Gender = gender;
            Phone = phone;
            Address = address;
        }
    }
}
