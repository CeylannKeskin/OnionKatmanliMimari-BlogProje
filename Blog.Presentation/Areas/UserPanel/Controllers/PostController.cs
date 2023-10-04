using AutoMapper;
using Blog.Application.Models.DTOs;
using Blog.Application.Services.PostService;
using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using Blog.Presentation.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blog.Presentation.Areas.UserPanel.Controllers
{
    
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public PostController(IMapper mapper, UserManager<AppUser> userManager, IPostService postService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _postService = postService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPost()
        {
            var postDTO = _postService.CreatePostAsync().Result;
            CreatePostVM postVM = new CreatePostVM();

            List<GenreDTO> genres = postDTO.Genres.ToList();
            SelectList items = new SelectList(genres, "Id", "Name");

            ViewBag.GenreList = items;
            //ViewBag.Genres = new SelectList(postVM.Genres, "GenreId", "Name");

            return View(postVM);
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(CreatePostVM post)
        {
            if (ModelState.IsValid)
            {
                CreatePostDTO postDTO = new CreatePostDTO();
                postDTO.Title = post.Title;
                postDTO.Content = post.Content;
                postDTO.GenreId = post.GenreId;

                string imageName = new Random().Next(1, 100000).ToString() + "_" + post.ImageFile.FileName;
                postDTO.ImagePath = imageName;

                FileStream fs = new FileStream("wwwRoot/Images/PostImages/" + imageName, FileMode.Create);

                await post.ImageFile.CopyToAsync(fs);
                fs.Close();

                AppUser user = await _userManager.GetUserAsync(User);
                postDTO.AppUserId = user.Id;


                await _postService.CreatePostAsync(postDTO);
                return View();

            }
            return View();
        }
    }
}
