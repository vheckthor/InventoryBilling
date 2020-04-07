namespace DataMangement.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransactionDetail
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public decimal? Rate { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? Total { get; set; }

        public int? DealCustomerId { get; set; }

        public DateTime? AddedDate { get; set; }
    }
}
