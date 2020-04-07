using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.DataBaseClasses;

namespace DataManagement.DbCommunication
{
    public class StoreDbContext:DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<TransactionDetails>TransactionDetails { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<DeaCustomer> DeaCustomer { get; set; }

    }
}
