namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaticPage")]
    public partial class StaticPage
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên trang tĩnh")]
        [DisplayName("Tên trang tĩnh")]
        [StringLength(200)]
        public string name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập nội dung trang tĩnh")]
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
