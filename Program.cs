using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TMS; 

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to DI container
builder.Services.AddScoped<UserService>();

// Add controllers in a whole project e.g: userController
builder.Services.AddControllers();

var app = builder.Build();

// Map controllers: to route HTTP requests to controller actions
app.MapControllers();

app.Run();
