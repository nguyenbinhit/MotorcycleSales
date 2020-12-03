using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebXe.Models
{
    public class LoginClientModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        [DisplayName("Tên đăng nhập")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DisplayName("Mật khẩu")]
        public string PassWord { get; set; }
    }
}