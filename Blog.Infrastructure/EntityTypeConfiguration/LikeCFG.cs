using Blog.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.EntityTypeConfiguration
{
    internal class LikeCFG:BaseEntityConfiguration<Like>
    {
        public override void Configure(EntityTypeBuilder<Like> builder)
        {
            base.Configure(builder);
        }
    }
}
