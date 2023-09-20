using Blog.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class PostRepository:BaseRepository<Post>
    {
        public PostRepository(BlogContext context):base(context)
        {
            
        }
    }
}
