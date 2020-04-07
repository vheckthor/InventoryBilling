using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement;

namespace DataManagement.DataBaseClasses
{
    public class Transactions:ITransactions
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int DeaCustomerId { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public int AddedBy { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
