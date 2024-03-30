using Microsoft.EntityFrameworkCore;
using Heladeria.API.Data;
namespace Heladeria.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<Heladeria.API.Data.HeladeriaEntidadesContext>(Option => {
                Option.UseSqlServer("data source=LAPTOP-IAGKS8VT\\SQLEXPRESS;initial catalog=Heladeria;integrated security=True;MultipleActiveResultSets=True");
            });
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
        }
    }
}