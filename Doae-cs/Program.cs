using Doae.database;
using Doae.Repositories;
using Doae.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Doae
{
    public class Program
    {
        public static void Main(string [] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string mySqlConnection = 
            builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
                options.UseMySql(mySqlConnection,
                    ServerVersion.AutoDetect(mySqlConnection)));


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IInstitutionRepository, InstitutionRepository>();
            builder.Services.AddScoped<IDonationRepository, DonationRepository>();
            builder.Services.AddScoped<ITargetRepository, TargetRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IRelationRepository, RelationRepository>();

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