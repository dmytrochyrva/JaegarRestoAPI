using JaegarRestoAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("JaegarRestoDB");

builder.Services.AddScoped<IDishesRepository, DishesRepository>();
builder.Services.AddDbContext<JaegarRestoContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(connectionString,  ServerVersion.AutoDetect(connectionString))
);
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
