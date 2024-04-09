<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
=======
using Intex1_10.Models;
using Microsoft.EntityFrameworkCore;
>>>>>>> 93eff35111292159783241a3466e07f75d8c39cb

using Intex1_10.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

<<<<<<< HEAD
builder.Services.Configure<IdentityOptions>(options =>
{
    // Default Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 14;
    options.Password.RequiredUniqueChars = 1;
});

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});
=======
builder.Services.AddDbContext<IntexDatabaseContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:IntexConnection"]);
});

builder.Services.AddScoped<IIntexRepository, EFIntexRepository>(); 
>>>>>>> 93eff35111292159783241a3466e07f75d8c39cb

builder.Services.AddDbContext<IntexDatabaseContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:IntexConnection"]);
});

builder.Services.AddScoped<IIntexRepository, EFIntexRepository>(); 

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
app.UseCookiePolicy();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();