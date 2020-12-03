namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        [StringLength(200)]
        [DisplayName("Tên tài khoản")]
        public string name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên hiển thị(Họ và tên)")]
        [StringLength(200)]
        [DisplayName("Tên hiển thị")]
        public string displayname { get; set; }

       
        [StringLength(200)]
        [DisplayName("Mật khẩu")]
        public string password { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [DisplayName("Số điện thoại")]
        public string phone { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ nơi ở hiện tại")]
        [DisplayName("Địa chỉ")]
        public string address { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [DisplayName("Email")]
        public string email { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Vui lòng chọn hình ảnh đại diện")]
        [DisplayName("Hình ảnh")]
        public string thunbar { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập chức vụ")]
        [StringLength(200)]
        [DisplayName("Chức vụ")]
        public string type_account { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày tạo")]
        public DateTime date_created { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày cập nhật")]
        public DateTime? date_update { get; set; }
    }
}
