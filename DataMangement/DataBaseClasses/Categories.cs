using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.DataBaseClasses
{
    public class Categories:ICategories
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        public int AddedBy { get; set; }
    }
}
