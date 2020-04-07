using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public interface ITransactions
    {
        int Id { get; set; }
        string Type { get; set; }
        int DeaCustomerId { get; set; }
        decimal GrandTotal { get; set; }
        decimal Tax { get; set; }
        decimal Discount { get; set; }
        int AddedBy { get; set; }
        DateTime TransactionDate { get; set; }
    }
}
