using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebXe.Common
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }
        public string UserImage { get; set; }
    }
}