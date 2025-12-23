using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlashTech.Models
{
  
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
      
        public int brandId { get; set; }
        public Brands brands { get; set; }
        public string color { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string storage { get; set; }
        public string GPU { get; set; }
        public decimal price { get; set; }
        public int? discount { get; set; }
        public decimal? promotionalPrice { get; set; }
           
        public int quantity { get; set; }
        public string? status { get; set; }
        public string? image { get; set; }


    }
}