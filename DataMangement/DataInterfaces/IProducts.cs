using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public interface IProducts
    {
        int Id { get; set; }
        string Name { get; set; }
        int Category { get; set; }
        string Description { get; set; }
        decimal Rate { get; set; }
        decimal Quantity { get; set; }
        DateTime AddedDate { get; set; }
        int AddedBy { get; set; }
    }
}
