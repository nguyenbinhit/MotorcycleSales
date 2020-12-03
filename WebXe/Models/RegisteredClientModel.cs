using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebXe.Models
{
    public class RegisteredClientModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        [DisplayName("Họ tên")]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        [DisplayName("Tên đăng nhập")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DisplayName("Mật khẩu")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Độ dài mật khẩu ít nhất 5 ký tự.")]
        public string PassWord { get; set; }

        [DisplayName("Nhập lại mật khẩu")]
        [Compare("PassWord", ErrorMessage = "Xác nhận mật khẩu không đúng.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}