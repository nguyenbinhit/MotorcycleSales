namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Feedbacks = new HashSet<Feedback>();
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm(xe)")]
        [DisplayName("Tên sản phẩm(xe)")]
        [StringLength(200)]
        public string name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá sản phẩm")]
        [DisplayName("Giá sản phẩm")]
        public double price { get; set; }

        [DisplayName("Giá khuyễn mãi sản phẩm")]
        public double? sale { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số sản phẩm")]
        [DisplayName("Số lượng sản phẩm")]
        public int number { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập thông só kỹ thuật sản phẩm")]
        [DisplayName("Thông số kỹ thuật")]
        public string information { get; set; }

        public int? viewproduct { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập hình ảnh sản phẩm")]
        [DisplayName("Hình ảnh chính")]
        [StringLength(200)]
        public string imagemain { get; set; }

        [StringLength(200)]
        [DisplayName("Hình ảnh con")]
        public string imagechild1 { get; set; }

        [StringLength(200)]
        [DisplayName("Hình ảnh con")]
        public string imagechild2 { get; set; }

        [StringLength(200)]
        [DisplayName("Hình ảnh con")]
        public string imagechild3 { get; set; }

        [DisplayName("Hãng xe")]
        public int id_CarManufacturer { get; set; }

        [DisplayName("Thể loại xe")]
        public int id_Category { get; set; }

        [DisplayName("Dung tích xi lanh xe")]
        public int id_CylinderCapacity { get; set; }

        [DisplayName("Màu xe")]
        public int id_Color { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày nhập")]
        public DateTime date_created { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày cập nhật")]
        public DateTime? date_update { get; set; }

        public virtual CarManufacturer CarManufacturer { get; set; }

        public virtual Category Category { get; set; }

        public virtual Color Color { get; set; }

        public virtual CylinderCapacity CylinderCapacity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
