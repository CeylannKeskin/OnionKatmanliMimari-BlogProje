using Blog.Application.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services.AppUserService
{
    public interface IAppUserService
    {
        Task<SignInResult> LoginAsync(LoginDTO login);
        Task Logout();
        Task<IdentityResult> RegisterAsync(RegisterDTO register);
        Task<IdentityResult> RegisterAsync(KayitDTO register);
    }
}
