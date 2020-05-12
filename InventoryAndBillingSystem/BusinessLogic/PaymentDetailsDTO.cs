using DataMangement.EF;

namespace InventoryAndBillingSystem.BusinessLogic
{
    public class PaymentDetailsDTO
    {
        public int TransactionId { get; set; }

        public decimal AmountPaid { get; set; }

        public decimal BalanceorChange { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}