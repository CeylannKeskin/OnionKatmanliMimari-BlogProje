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
    public class AppUser:IdentityUser<int>,IBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ImagePath { get; set; }

        //???
        //[NotMapped]
        //public IFormFile ImageFile { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } 


        //Navigation Prop....
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Like>? Likes { get; set; }
    }
}
