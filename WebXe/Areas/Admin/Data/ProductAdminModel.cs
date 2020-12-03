using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebXe.Areas.Admin.Data
{
    public class ProductAdminModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacterId { get; set; }
        public string ManufacterName { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public string Image { get; set; }
    }
}