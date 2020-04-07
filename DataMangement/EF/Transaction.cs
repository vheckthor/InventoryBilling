namespace DataMangement.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Type { get; set; }

        public decimal? GrandTotal { get; set; }

        public int? DealCustomerId { get; set; }

        public decimal? Tax { get; set; }

        public decimal? Discount { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? TransactionDate { get; set; }
    }
}
