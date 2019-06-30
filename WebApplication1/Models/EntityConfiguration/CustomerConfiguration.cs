using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.EntityConfiguration
{
    public class CustomerConfiguration: EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            //Property(c => c.Name).IsOptional().HasMaxLength(255);

            HasRequired(c => c.Membership)
                .WithMany(m => m.Customers)
                .HasForeignKey(c => c.MembershipTypeId);


        }
    }
}