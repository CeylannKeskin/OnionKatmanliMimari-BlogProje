using Blog.Domain.Entities.Abstract;
using Blog.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Concrete
{
    public class AppRole:IdentityRole<int>,IBaseEntity
    {

        public DateTime CreateDate { get; set; }= DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
