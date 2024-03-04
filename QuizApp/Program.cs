using Microsoft.EntityFrameworkCore;
using QuizApp.Models;
using Microsoft.AspNetCore.Identity;
using QuizApp.Data;
using QuizApp;
using Microsoft.Extensions.DependencyInjection;
using QuizApp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("QuizAppContextConnection") ?? throw new InvalidOperationException("Connection string 'QuizAppContextConnection' not found.");

builder.Services.AddDbContext<QuizAppContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false)
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<QuizAppContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireUppercase = false;
});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
 

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

app.MapRazorPages();
app.Run();
