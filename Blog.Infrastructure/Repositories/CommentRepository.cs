using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class CommentRepository:BaseRepository<Comment>,ICommentRepository
    {
        public CommentRepository(BlogContext context):base(context)
        {
            
        }
    }
}
