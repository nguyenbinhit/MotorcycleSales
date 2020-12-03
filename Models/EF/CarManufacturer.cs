namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarManufacturer")]
    public partial class CarManufacturer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarManufacturer()
        {
            Products = new HashSet<Product>();
        }

        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên hãng xe")]
        [StringLength(200)]
        [DisplayName("Tên hãng xe")]
        public string name { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn logo của hãng xe")]
        [StringLength(200)]
        [DisplayName("Logo")]
        public string thunbar { get; set; }

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
