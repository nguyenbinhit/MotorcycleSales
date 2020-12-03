namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tiêu đề tin tức")]
        [DisplayName("Tiêu đề")]
        [StringLength(200)]
        public string name { get; set; }

        [DisplayName("Nội dung")]
        public string content { get; set; }

        [StringLength(200)]
        [DisplayName("Hình ảnh")]
        public string thunbar { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày tạo")]
        public DateTime date_created { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày cập nhật")]
        public DateTime? date_update { get; set; }
    }
}
