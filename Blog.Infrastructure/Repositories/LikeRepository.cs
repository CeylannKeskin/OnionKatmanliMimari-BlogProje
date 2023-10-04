using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class LikeRepository:BaseRepository<Like>,ILikeRepository
    {
        public LikeRepository(BlogContext context):base(context)
        {
            
        }
    }
}
