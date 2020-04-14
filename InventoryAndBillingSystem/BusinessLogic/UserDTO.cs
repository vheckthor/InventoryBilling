using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryAndBillingSystem.BusinessLogic
{
    public class UserDTO
    {
        public int id { get; set; }

        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [StringLength(50)]
        [Required]
        public string UserName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Password { get; set; }

        [StringLength(80)]
        [Required]
        public string Contact { get; set; }

        [StringLength(100)]
        [Required]
        public string Address { get; set; }

        [StringLength(10)]
        [Required]
        public string Gender { get; set; }

        [StringLength(20)]
        [Required]
        public string UserType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AddedDate { get; set; }

        public int? AddedBy { get; set; }
    }
}