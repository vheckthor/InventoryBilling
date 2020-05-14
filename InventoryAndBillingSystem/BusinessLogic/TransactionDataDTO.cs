using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace InventoryAndBillingSystem.BusinessLogic
{
    public class TransactionDataDTO
    {
        public  int Id { get; set; }
        public string Type { get; set; }

        public decimal? GrandTotal { get; set; }

        public int? DealCustomerId { get; set; }

        public decimal? Tax { get; set; }

        public decimal? Discount { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? TransactionDate { get; set; }

        //public DataTable DataTableFromTransaction { get; set; }
    }
}