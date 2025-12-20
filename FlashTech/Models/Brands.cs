using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlashTech.Models
{
    public class Brands
    {
        public int Id { get; set; }
        
        
        [Required(ErrorMessage = "Username is required")]
        public String name { get; set; }
    }
    
}