using Blog.Domain.Entities.Abstract;
using Blog.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Concrete
{
    public class Comment:IBaseEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } 

        public int? AppUserId { get; set; }
        public int? PostId { get; set; }

        public AppUser? AppUser { get; set; }
        public Post? Post { get; set; }
    }
}
