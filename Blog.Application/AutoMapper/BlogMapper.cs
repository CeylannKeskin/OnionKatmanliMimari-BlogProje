using AutoMapper;
using Blog.Application.Models.DTOs;
using Blog.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Application.AutoMapper
{
    public class BlogMapper:Profile
    {
        public BlogMapper()
        {
            //Property adları aynı ise...
            CreateMap<AppUser, RegisterDTO>().ReverseMap();

            //Property adları farklı ise...
            CreateMap<AppUser,KayitDTO>()
                .ForMember(x=>x.Ad,x=>x.MapFrom(y=>y.FirstName))
                .ForMember(x => x.Soyad, x => x.MapFrom(y => y.LastName))
                .ForMember(x => x.KullaniciAdi, x => x.MapFrom(y => y.UserName))
                .ForMember(x => x.Sifre, x => x.MapFrom(y => y.PasswordHash))
                .ForMember(x => x.ResimYolu, x => x.MapFrom(y => y.ImagePath))
                .ForMember(x=>x.EPosta, x=>x.MapFrom(y=>y.Email))
                .ReverseMap();
            CreateMap<Post, CreatePostDTO>().ReverseMap();
            CreateMap<Genre, GenreDTO>().ReverseMap();
        }
    }
}
