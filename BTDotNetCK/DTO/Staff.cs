using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class Staff
    {
        public string ID_Staff { get; set; }
        public string NameStaff { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string ID_Card { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Image { get; set; }
        public string AccountUsername { get; set; }

        public Staff()
        {

        }

        public Staff(string ID_Staff, string nameStaff, string email, DateTime dateOfBirth, string gender, 
                        string phone, string ID_Card, string address, DateTime startDate, DateTime? endDate, 
                        string image, string accountUsername)
        {
            this.ID_Staff = ID_Staff;
            NameStaff = nameStaff;
            Email = email;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Phone = phone;
            this.ID_Card = ID_Card;
            Address = address;
            StartDate = startDate;
            EndDate = endDate;
            Image = image;
            AccountUsername = accountUsername;
        }
    }
}
