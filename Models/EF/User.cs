namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Feedbacks = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
        }

        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        [DisplayName("Tên đăng nhập")]
        [StringLength(200)]
        public string name { get; set; }


        [DisplayName("Mật khẩu")]
        [StringLength(200)]
        public string password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        [DisplayName("Họ và tên")]
        public string displayname { get; set; }

        [DisplayName("Số điện thoại")]
        [StringLength(10)]
        public string phone { get; set; }

        [StringLength(200)]
        [DisplayName("Hình ảnh đại diện")]
        public string thunbar { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [DisplayName("Email")]
        [StringLength(200)]
        public string email { get; set; }

        [StringLength(200)]
        [DisplayName("Địa chỉ")]
        public string address { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày tạo")]
        public DateTime date_created { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày cập nhật")]
        public DateTime? date_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
