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
        Task CreatePost(CreatePostDTO post);
        Task<CreatePostDTO> CreatePost();
        Task<int> UpdatePost(UpdatePostDTO post);

        Task DeletePost(int postId);

        Task<PostVM>? GetPost(int postID);
        Task<List<PostVM>>? GetAllPosts();
    }
}
