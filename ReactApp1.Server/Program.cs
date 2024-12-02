using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReactApp1.Server;
using ReactApp1.Server.Classes;
using ReactApp1.Server.Functions;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        builder => builder.WithOrigins("https://localhost:51125")  // Allow the frontend port
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});
// Add services to the container.
builder.Services.AddScoped<HuurAccountService>();
builder.Services.AddScoped<HashFunction>();
// Configure the DatabaseContext
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite("Data Source=database.db")); // Replace with your connection string if needed
//builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql("Braunschweig"));
//builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql(configuration.GetConnectionString("CarAndAll")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();


}



app.UseCors("AllowLocalhost");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run("https://localhost:5126");
