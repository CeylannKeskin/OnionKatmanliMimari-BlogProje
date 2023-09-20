using Blog.Application.AutoMapper;
using Blog.Application.Services.AppUserService;
using Blog.Domain.Entities.Concrete;
using Blog.Domain.Repositories;
using Blog.Infrastructure;
using Blog.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<BlogContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));
builder.Services.AddIdentity<AppUser, AppRole>(x => 
{
    //Diğer ayarlar buraya yazılabilinir....
    x.Password.RequiredLength = 6;
}
).AddEntityFrameworkStores<BlogContext>();


builder.Services.AddTransient<IAppUserService,AppUserService>();
builder.Services.AddTransient<IAppUserRepository, AppUserRepository>();



//AutoMapper için gerekli ayar...
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(BlogMapper)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
