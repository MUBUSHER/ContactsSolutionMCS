using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsSolutionMCS
{
    public class ContactDbContext : DbContext
    {

        public DbSet<ContactInfo> contactInfo { get; set; }

        public ContactDbContext()
            :base("ContactConnectionString")
        { 
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContactInfo>().ToTable("ContactInfo");
        }
    }
}


