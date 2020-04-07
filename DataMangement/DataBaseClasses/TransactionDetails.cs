using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement;

namespace DataManagement.DataBaseClasses
{
    public class TransactionDetails:ITransactionDetails
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Rate { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
        public int DeaCustomerId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
