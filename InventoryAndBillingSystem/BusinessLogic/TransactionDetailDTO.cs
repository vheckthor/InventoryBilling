using System;

namespace InventoryAndBillingSystem.BusinessLogic
{
    public class TransactionDetailDTO
    {

        public int? ProductId { get; set; }

        public decimal? Rate { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? Total { get; set; }

        public int? DealCustomerId { get; set; }

        public DateTime? AddedDate { get; set; }
    }
}