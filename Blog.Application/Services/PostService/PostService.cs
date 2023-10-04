using AutoMapper;
using Blog.Application.Models.DTOs;
using Blog.Application.Models.VMs;
using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;
        public PostService(IPostRepository postRepository, IGenreRepository genreRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public async Task CreatePostAsync(CreatePostDTO post)
        {
            Post newPost = new Post();
            _mapper.Map(post, newPost);

            await _postRepository.AddAsync(newPost);

        }

        public async Task<CreatePostDTO> CreatePostAsync()
        {
            CreatePostDTO newPost = new CreatePostDTO();
            List<GenreDTO> genres = new List<GenreDTO>();

            var comingFromDbGenres = _genreRepository.GetAll().ToList();


            _mapper.Map(comingFromDbGenres, genres);


            newPost.Genres = genres;

            return newPost;
        }

        public Task DeletePostAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostVM>>? GetAllPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PostVM>? GetPostAsync(int postID)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePostAsync(UpdatePostDTO post)
        {
            throw new NotImplementedException();
        }
    }
}
