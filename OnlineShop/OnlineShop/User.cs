﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class User
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Passwordsalt { get; set; }
       // public bool IsAdmin { get; set; } = false;

    }
}
