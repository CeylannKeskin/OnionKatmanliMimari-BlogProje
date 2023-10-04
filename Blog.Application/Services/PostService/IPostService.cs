using Blog.Application.Models.DTOs;
using Blog.Application.Models.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services.PostService
{
    public interface IPostService
    {
        Task CreatePostAsync(CreatePostDTO post);
        Task<CreatePostDTO> CreatePostAsync();
        Task<int> UpdatePostAsync(UpdatePostDTO post);

        Task DeletePostAsync(int postId);

        Task<PostVM>? GetPostAsync(int postID);
        Task<List<PostVM>>? GetAllPostsAsync();
    }
}
