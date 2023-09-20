using AutoMapper;
using Blog.Application.Models.DTOs;
using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services.AppUserService
{
    public class AppUserService : IAppUserService
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AppUserService(
            SignInManager<AppUser> signInManager,
            UserManager<AppUser> userManager,
            IAppUserRepository userRepository,
            IMapper mapper
            )
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<SignInResult> LoginAsync(LoginDTO login)
        {
            AppUser user = await _userRepository.GetFirstOrDefaultAsync(x => x.UserName == login.UserName);

            return await _signInManager.PasswordSignInAsync(user, login.Password, false, false);

        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> RegisterAsync(RegisterDTO register)
        {
            AppUser user = new AppUser();
            //user.FirstName = register.FirstName;
            //user.LastName = register.LastName;
            //user.Email = register.Email;
            //user.UserName = register.Email;
            //user.ImagePath = register.ImagePath;
            _mapper.Map(register, user);
            user.UserName = user.Email;

            //user.PasswordHash = new PasswordHasher<AppUser>().HashPassword(user,register.Password);

            var result = await _userManager.CreateAsync(user, register.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                //Add a  Role for the user...(USER)
                await _userManager.AddToRoleAsync(user, "User");
            }
            return result;
        }

        public async Task<IdentityResult> RegisterAsync(KayitDTO register)
        {
            AppUser user = new AppUser();
           
            _mapper.Map(register, user);
            user.UserName = user.Email;

            var result = await _userManager.CreateAsync(user, register.Sifre);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                //Add a  Role for the user...(USER)
                await _userManager.AddToRoleAsync(user, "User");
            }
            return result;
        }
    }
} 