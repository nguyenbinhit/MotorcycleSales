namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên thể loại xe")]
        [DisplayName("Tên thể loại")]
        [StringLength(200)]
        public string name { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày tạo")]
        public DateTime date_created { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày cập nhật")]
        public DateTime? date_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
