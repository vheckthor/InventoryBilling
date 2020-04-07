using System;

namespace DataManagement
{
    public interface ITransactionDetails
    {
        int Id { get; set; }
        int ProductId { get; set; }
        decimal Rate { get; set; }
        decimal Quantity { get; set; }
        decimal Total { get; set; }
        int DeaCustomerId { get; set; }
        DateTime AddedDate { get; set; }
    }
}