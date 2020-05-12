namespace DataMangement.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentDetail
    {
        public int Id { get; set; }

        public int TransactionId { get; set; }

        [Column(TypeName = "money")]
        public decimal AmountPaid { get; set; }

        [Column(TypeName = "money")]
        public decimal BalanceorChange { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
