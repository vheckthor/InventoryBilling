using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    interface IDeaCustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Contact { get; set; }
        string Address { get; set; }
        DateTime AddedDate { get; set; }
        int AddedBy { get; set; }
    }
}
