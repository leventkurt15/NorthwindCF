using NorthwindCF.DAL.Mapping;
using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCF.DAL
{
    public class NorthwindDbConext : DbContext
    {
        public NorthwindDbConext() : base("name=ConnectionStringAdi")
        {
            Database.SetInitializer<NorthwindDbConext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new OrderMapping ());

        }
        public virtual DbSet<Customer>Customers { get ; set;}
        public virtual DbSet<Order>Orders { get; set; }

    }
}
