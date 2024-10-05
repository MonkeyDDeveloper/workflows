using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Context;
using PortfolioBackend.Models;
using System;
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
builder.Services.AddCors(options => options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();

using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    var logger = serviceScope.ServiceProvider.GetRequiredService<ILogger<Program>>();
    var db = serviceScope.ServiceProvider.GetRequiredService<PortfolioDbContext>().Database;

    logger.LogInformation("Migrating database...");

    while (!db.CanConnect())
    {
        logger.LogInformation("Database not ready yet; waiting...");
        Thread.Sleep(1000);
    }

    try
    {
        serviceScope.ServiceProvider.GetRequiredService<PortfolioDbContext>().Database.Migrate();
        logger.LogInformation("Database migrated successfully.");
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An error occurred while migrating the database.");
    }
}

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
