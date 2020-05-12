namespace DataMangement.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public decimal? Rate { get; set; }

        public decimal? Quantity { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? Addedby { get; set; }
    }
}
