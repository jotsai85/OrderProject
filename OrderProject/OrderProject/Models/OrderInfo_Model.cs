using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderProject.Models
{
    public class OrderInfo_Model
    {
        public string OrderUID { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }
        public string OrderStatus { get; set; }
    }
}