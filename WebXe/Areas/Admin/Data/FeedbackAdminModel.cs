using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebXe.Areas.Admin.Data
{
    public class FeedbackAdminModel
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public int Product_ID { get; set; }
        public string Product_Image { get; set; }
        public int Star { get; set; }
        public string Note { get; set; }
    }
}