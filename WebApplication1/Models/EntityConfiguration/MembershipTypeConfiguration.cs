using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.EntityConfiguration
{
    public class MembershipTypeConfiguration: EntityTypeConfiguration<MembershipType>
    {
        public MembershipTypeConfiguration()
        {
            Property(m => m.Name).IsRequired();
        }
    }
}