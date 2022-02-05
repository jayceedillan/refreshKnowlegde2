using Microsoft.EntityFrameworkCore;
using core.Models;
using core.Repositry;
using core.IRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProfileRepository, ProfileRepository>();

// sqlcmd -S 127.0.0.1 -U SA -P 'Test@12345!'

//dotnet ef migrations add Initials
// dotnet ef database update
// "command": "/usr/bin/dotnet",
// "args": ["urls=http://localhost:5002"],
builder.Services.AddDbContextPool<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("learningConn")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
