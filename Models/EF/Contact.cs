namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên của bạn")]
        [StringLength(200)]
        [DisplayName("Họ tên")]
        public string name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [StringLength(200)]
        public string email { get; set; }

        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại phải là 10 ký tự.")]
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [DisplayName("Số điện thoại")]
        public string phone { get; set; }

        [DisplayName("Nội dung")]
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string note { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày liên hệ")]
        public DateTime date_created { get; set; }
    }
}
