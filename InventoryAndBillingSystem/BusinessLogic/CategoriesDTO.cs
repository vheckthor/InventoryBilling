using System;

namespace InventoryAndBillingSystem.BusinessLogic
{
    public class CategoriesDTO
    {
        public string Title { get; set; }

 
        public string Description { get; set; }

        public DateTime? DateAdded { get; set; }

        public int? Addedby { get; set; }
    }
}