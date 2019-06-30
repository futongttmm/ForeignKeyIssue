using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.EntityConfiguration
{
    public class MovieConfiguration: EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            //Property(m => m.Name).IsOptional();

            HasRequired(c => c.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(m => m.GenreId);
        }
    }
}