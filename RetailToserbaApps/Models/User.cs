using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailToserbaApps.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string NoTelepon { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; } 
    }
}
