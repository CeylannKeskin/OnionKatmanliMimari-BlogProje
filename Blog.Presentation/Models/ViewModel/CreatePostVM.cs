using Blog.Application.Models.DTOs;
using Blog.Presentation.Extension;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blog.Presentation.Models.ViewModel
{
    public class CreatePostVM
    {
        public string Title { get; set; }
        public string Content { get; set; }
        //public string? ImagePath { get; set; }
        [ImageFileExtensionValidator]
        public IFormFile ImageFile { get; set; }
        public int GenreId { get; set; }
        //public int? AppUserId { get; set; }

        public SelectList? Genres { get; set; }
    }
}
