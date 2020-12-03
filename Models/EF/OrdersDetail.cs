namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrdersDetail
    {
        public int id { get; set; }

        public int id_Bill { get; set; }

        public int id_Product { get; set; }

        public double price { get; set; }

        public int qty { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_created { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
