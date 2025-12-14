using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashTech.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Username is required")]
        public string? userName { get; set; }
        [Required (ErrorMessage = "Password is required")]
        public string? password { get; set; }
        [Required (ErrorMessage = "Email is required")]
        public string? email { get; set; }

        public string? address { get; set; }
        [Required (ErrorMessage = "Role is required")]
        public string? role { get; set; }
    }
}