using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderProject.Models
{
    public class Product_Model
    {
        public string PName { get; set; }
        public string ProductUID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }
    }
}