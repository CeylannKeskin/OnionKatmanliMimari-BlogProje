using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class AppRoleRepository:BaseRepository<AppRole>, IAppRoleRepository
    {
        public AppRoleRepository(BlogContext context):base(context)
        {
            
        }
    }
}
