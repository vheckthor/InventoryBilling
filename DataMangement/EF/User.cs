namespace DataMangement.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Column(TypeName = "text")]
        public string Password { get; set; }

        [StringLength(80)]
        public string Contact { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(20)]
        public string UserType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AddedDate { get; set; }

        public int? AddedBy { get; set; }
    }
}
