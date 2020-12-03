using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebXe.Areas.Admin.Data
{
    public class LoginAdminModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Mời bạn nhập tên đăng nhập.")]
        public string AccName { get; set; }

        [Required(ErrorMessage = "Mời bạn nhập mật khẩu.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}