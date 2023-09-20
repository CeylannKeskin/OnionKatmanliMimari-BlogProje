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
    internal class PostCFG:BaseEntityConfiguration<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(150).HasColumnType("varchar");
            builder.Property(x => x.Content).IsRequired().HasMaxLength(600).HasColumnType("varchar");
            builder.Property(x => x.ImagePath).IsRequired(false).HasMaxLength(30).HasColumnType("varchar");

            base.Configure(builder);
        }
    }
}
