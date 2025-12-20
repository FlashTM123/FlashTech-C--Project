using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashTech.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String password { get; set; }
        public String Gender { get; set; }
        public DateTime date_of_birth { get; set; }
        public String address { get; set; }
        public String image { get; set; } 
    }
}