using Blog.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.EntityTypeConfiguration
{
    internal class GenreCFG:BaseEntityConfiguration<Genre>
    {
        public override void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(25).HasColumnType("varchar");

            builder.HasData(
                new Genre { Id=1,  Name = "Bilim" }, 
                new Genre { Id=2,  Name = "Yazılım" }, 
                new Genre { Id=3,  Name = "Spor" } 
            );

            base.Configure(builder);
        }
    }
}
