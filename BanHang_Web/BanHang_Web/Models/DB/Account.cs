using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang_Web.Models.DB
{
    public partial class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public bool Active { get; set; }
    }
}
