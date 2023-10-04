using Blog.Application.Models.DTOs;
using Blog.Application.Services.AppUserService;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAppUserService _appUserService;

        public LoginController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginDTO login)
        {
            var result = await _appUserService.LoginAsync(login);
            if (result.Succeeded)
                return Content("Basarili");
            //Eklenecek!!!!
            else
                return Content("Basarisiz");
        }

        public IActionResult Logout()
        {
            _appUserService.Logout();
            return NoContent();
        }
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterDTO register)
        {
            await _appUserService.RegisterAsync(register);
            return RedirectToAction("Index", "Posts");
        }


        public IActionResult UyeKaydet()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UyeKaydet(KayitDTO register)
        {
            if (ModelState.IsValid)
            {
                await _appUserService.RegisterAsync(register);
                return RedirectToAction("Index", "Posts");
            }
            return View();
        }
    }
}
