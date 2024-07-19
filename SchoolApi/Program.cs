
using Microsoft.EntityFrameworkCore;
using School.Core;
using School.Infrastructure;
using School.Infrastructure.Context;
using School.Service;
namespace SchoolApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCoreDependecies()
                            .AddServiceDepencies()
                            .AddInfrastructurreDependencies();


            //Register Db
            builder.Services.AddDbContext<ApplicationDbContext>(Options => Options.UseSqlServer
            (builder.Configuration.GetConnectionString("DefaultConnection")));
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
        }
    }
}
