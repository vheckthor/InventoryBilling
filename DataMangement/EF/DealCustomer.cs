namespace DataMangement.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DealCustomer")]
    public partial class DealCustomer
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Contact { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? AddedBy { get; set; }
    }
}
