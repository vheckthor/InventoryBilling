using System;

namespace InventoryAndBillingSystem.BusinessLogic
{
    public class InventoryDTO
    {
        public int SerialNumber { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? Addedby { get; set; }
    }
}