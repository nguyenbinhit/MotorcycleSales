namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int id { get; set; }

        public int id_User { get; set; }

        public int id_Product { get; set; }

        public int star { get; set; }

        public string note { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_created { get; set; }

        public virtual User User { get; set; }

        public virtual Product Product { get; set; }
    }
}
