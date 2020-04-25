using System;

namespace InventoryAndBillingSystem.BusinessLogic
{
    public class DealCustomerDTO
    {

        public string Type { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        public string Address { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? AddedBy { get; set; }
    }
}