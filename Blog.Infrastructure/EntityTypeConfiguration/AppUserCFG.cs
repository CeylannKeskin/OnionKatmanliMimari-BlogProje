using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.EntityTypeConfiguration
{

    internal class AppUserCFG : BaseEntityConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(20).HasColumnType("varchar").IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(20).HasColumnType("varchar").IsRequired();
            builder.Property(x => x.ImagePath).IsRequired(false).HasMaxLength(30).HasColumnType("varchar");

            PasswordHasher<AppUser> hashPwd = new PasswordHasher<AppUser>();

            AppUser root = new AppUser()
            {
                Id = 1,
                FirstName = "Root",
                LastName = "Admin",
                Email = "root@admin.com",
                UserName = "root@admin.com",
                SecurityStamp = Guid.NewGuid().ToString()
                

            };
            root.PasswordHash= hashPwd.HashPassword(root, "RooT_123");
            
            
            builder.HasData(root) ;

            ///// ?????
            
            base.Configure(builder);
        }

    }

    //Problem NE?????
    //Her sınıf için yazacak mıyız????
    //HISSIYAT !!!

    //internal class AppUserCFG : IEntityTypeConfiguration<AppUser>
    //{
    //    public void Configure(EntityTypeBuilder<AppUser> builder)
    //    {
    //        builder.Property(x => x.CreateDate).IsRequired();
    //        builder.Property(x => x.ModifiedDate).IsRequired(false);
    //        builder.Property(x => x.DeleteDate).IsRequired(false);
    //        builder.Property(x => x.Status).IsRequired();

    //    }
    //}
}
