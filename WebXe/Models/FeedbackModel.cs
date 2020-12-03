using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebXe.Models
{
    public class FeedbackModel
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public int Product_ID { get; set; }
        public int Star { get; set; }
        public string Note { get; set; }
        public string User_Name { get; set; }
    }
}