using First_site_V2.Logic.Photoes;
using First_site_V2.Logic.UserManagment;
using First_site_V2.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;


// Add services to the container.
services.AddControllersWithViews();

//services.AddScoped<IUserManager, UserManager>();
//services.AddScoped<IPhotoManager, PhotoManager>();
var connectionString = builder.Configuration.GetConnectionString("DbConnection");
services.AddDbContext<GaisContext>(param => param.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
