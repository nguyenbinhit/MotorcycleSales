using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebXe.Models
{
    public class OrderDetailClientModel
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
    }
}