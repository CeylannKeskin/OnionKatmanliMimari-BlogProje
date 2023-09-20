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
    internal class AppRoleCFG :BaseEntityConfiguration<AppRole>
    {
        public override void Configure(EntityTypeBuilder<AppRole> builder)
        {

            builder.HasData(
               new AppRole { Id = 1, Name = "Admin", NormalizedName="ADMIN" },
               new AppRole { Id = 2, Name = "User", NormalizedName="USER" }
           );

            base.Configure(builder);
        }

    }
    //internal class AppRoleCFG : IEntityTypeConfiguration<AppRole>
    //{
    //    public void Configure(EntityTypeBuilder<AppRole> builder)
    //    {
    //        builder.Property(x => x.CreateDate).IsRequired();
    //        builder.Property(x => x.ModifiedDate).IsRequired(false);
    //        builder.Property(x => x.DeleteDate).IsRequired(false);
    //        builder.Property(x => x.Status).IsRequired();
    //    }
    //}
}
