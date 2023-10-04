using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class GenreRepository:BaseRepository<Genre>,IGenreRepository
    {
        public GenreRepository(BlogContext context):base(context)
        {
            
        }
    }
}
