﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }

        public Account()
        {

        }

        public Account(string userName, string password, int role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
