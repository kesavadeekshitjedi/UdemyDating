using Microsoft.EntityFrameworkCore;

using UdemyDating.WebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
        );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
/*
app.UseHttpsRedirection();

app.UseAuthorization();*/

app.MapControllers();

app.Run();
