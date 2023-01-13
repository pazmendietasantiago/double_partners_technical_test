using DoublePartnersAPI.Models;
using DoublePartnersAPI.Repository.Implementation;
using DoublePartnersAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DoublePartnersAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //const string corsUnrestrictedPolicy = "";

            var configuration = builder.Configuration;

            string connectionString = configuration.GetConnectionString("MainConnection") ?? string.Empty;

            builder.Services.AddControllers();

            builder.Services.AddDbContext<DoublePartnersContext>(options =>
                options.UseSqlServer(connectionString)
            );

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddScoped<ISecurityRepository, SecurityRepository>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
                options.AddDefaultPolicy(builder =>
                    builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader()
                )
            );

            builder.Services.AddAutoMapper(typeof(Program));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors();

            app.MapControllers();

            app.Run();
        }
    }
}