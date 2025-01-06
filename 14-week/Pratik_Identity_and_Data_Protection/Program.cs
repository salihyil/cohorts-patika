using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pratik_Identity_and_Data_Protection.Contexts;
using Pratik_Identity_and_Data_Protection.Models;
using Scalar.AspNetCore;

namespace Pratik_Identity_and_Data_Protection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddOpenApi();

            // Add services to the container.
            builder.Services.AddDbContext<IdentityDataProtectionDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            // Add Identity
            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<IdentityDataProtectionDbContext>()
            .AddDefaultTokenProviders();

            builder.Services.AddControllers();
         

            var app = builder.Build();
            app.MapScalarApiReference(options =>
            {
                options.WithTitle("IdentityandDataProtection API")
                    .WithTheme(ScalarTheme.Default)
                    .WithDefaultHttpClient(ScalarTarget.JavaScript, ScalarClient.Fetch);
            });

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            // Add authentication & authorization
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
