using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public interface ICategories
    {
        int Id { get; set; }
        string Description { get; set; }
        DateTime AddedDate { get; set; }
        int AddedBy { get; set; }

    }
}
