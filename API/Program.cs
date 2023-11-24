
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<API.Data.DataContext> (Opt =>
 {
    Opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
 }
 );

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();