using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebXe.Common
{
    [Serializable]
    public class AccountLogin
    {
        public long AccountID { get; set; }
        public string AccountName { get; set; }
        //public string AccountDisplayName { get; set; }
    }
}