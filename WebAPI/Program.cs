using ApplicationCore.Interfaces.Services;
using Infrastructure;
using Infrastructure.EF.Services;
using Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;
using WebAPI.Mappers;

namespace WebAPI
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

            builder.Services.AddAutoMapper(typeof(SuperheroProfile));
            builder.Services.AddAutoMapper(typeof(SuperheroDtoMapper));

            builder.Services.AddDbContext<SuperheroDbContext>(sql => sql.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            builder.Services.AddTransient<ISuperheroService, SuperheroUserServiceEF>();

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