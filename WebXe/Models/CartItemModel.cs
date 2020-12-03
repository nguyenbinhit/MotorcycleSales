using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebXe.Models
{
    [Serializable]
    public class CartItemModel
    {
        public Product Product { get; set; }
        public int Qty { get; set; }
    }
}