using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Models.DTOs
{
    public class KayitDTO
    {
        [Required(ErrorMessage ="Ad giriniz...")]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string? KullaniciAdi { get; set; }
        public string EPosta { get; set; }
        public string? ResimYolu { get; set; }
        
        public string Sifre { get; set; }
        [Compare("Sifre",ErrorMessage ="Sifre ve sifre tekrar aynı olmalı...")]
        public string SifreTekrar { get; set; }
        public IFormFile? ResimDosyasi { get; set; }
    }
}
