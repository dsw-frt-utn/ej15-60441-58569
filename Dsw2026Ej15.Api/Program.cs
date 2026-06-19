using Dsw2026Ej15.Domain;
using Dsw2026Ej15.Data;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Dsw2026Ej15.Domain.Interfaces;
using Dsw2026Ej15.Api.Middlewares;

namespace Dsw2026Ej15.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IPersistence, PersistenceInMemory>();

            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseMiddleware<ExceptionMiddleware>();
            
            app.UseAuthorization();
            
            app.MapControllers();

            app.MapHealthChecks("/health-check");

            app.Run();
        }
    }
}
