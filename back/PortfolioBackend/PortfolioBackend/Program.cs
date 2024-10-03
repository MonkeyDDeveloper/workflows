using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Context;
using PortfolioBackend.Models;
Env.Load();

var envDbConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
var dbConnectionString = envDbConnectionString;
var builder = WebApplication.CreateBuilder(args);

// Configuring context
if(dbConnectionString == null)
{
    Console.WriteLine("No se ha ingresado ningún string de conexión a base de datos");
    return;
}

builder.Services.AddDbContext<PortfolioDbContext>(options => options.UseNpgsql(dbConnectionString));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
