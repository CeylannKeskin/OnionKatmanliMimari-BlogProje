using Blog.Domain.Entities.Concrete;
using Blog.Infrastructure.EntityTypeConfiguration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure
{
    public class BlogContext:IdentityDbContext<AppUser,AppRole,int>
    {

        public BlogContext():base()
        {
            
        }
        public BlogContext(DbContextOptions<BlogContext>options):base(options)
        {
            
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=.;initial catalog=KD16_BlogDB;integrated security=true");
            
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //CONFIG ayarları...
            builder.ApplyConfiguration<AppRole>(new AppRoleCFG());
            builder.ApplyConfiguration<AppUser>(new AppUserCFG());
            
            builder.ApplyConfiguration<Genre>(new GenreCFG());
            builder.ApplyConfiguration<Post>(new PostCFG());
            builder.ApplyConfiguration<Comment>(new CommentCFG());
            builder.ApplyConfiguration<Like>(new LikeCFG());


            //Problem Ne ???
            //Buyuk projelerde tum ayarları veya deger atamaları buradan yaparsak yuzlerce satır arasında istenilen degerleri bulmak zorlaşacaktir...

            //builder.Entity<AppUser>().Property(x => x.CreateDate).IsRequired();
            //builder.Entity<AppRole>().Property(x => x.CreateDate).IsRequired();


            //Admin kullanıcısına; admin rol ataması yapıyoruz...
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = 1,
                UserId = 1
            });

            base.OnModelCreating(builder);
        }
    }
}
