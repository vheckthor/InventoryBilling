namespace DataMangement.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public DateTime? DateAdded { get; set; }

        public int? Addedby { get; set; }
    }
}
