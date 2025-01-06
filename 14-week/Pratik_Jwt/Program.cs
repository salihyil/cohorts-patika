using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Pratik_Jwt.Contexts;
using Scalar.AspNetCore;

namespace Pratik_Jwt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi("v1", options => { options.AddDocumentTransformer<BearerSecuritySchemeTransformer>(); });
            
            // db bağlantı
            builder.Services.AddDbContext<JwtDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            //jwt
            builder.Services.AddAuthentication(options =>
            {
                // [Authorize] 302 alıyoduk -> 401 unauthorized hatası almak için
                // jwt ile authentication yapılacak
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                // jwt ile challenge yapılacak
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                // jwt ile scheme yapılacak
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        // issuer: token'ın hangi sunucudan geldiğini kontrol eder  
                        ValidateIssuer = true,
                        // audience: token'ın hangi kullanıcıya ait olduğunu kontrol eder
                        ValidateAudience = true,
                        // lifetime: token'ın süresi dolup dolmadığını kontrol eder
                        ValidateLifetime = true,
                        // signing key: token'ın imzalanıp imzalanmadığını kontrol eder
                        ValidateIssuerSigningKey = true,

                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                    };
                });

            var app = builder.Build();

            app.MapScalarApiReference(options =>
            {
                options.WithTitle("Jwt API")
                       .WithTheme(ScalarTheme.Default)
                       .WithDefaultHttpClient(ScalarTarget.JavaScript, ScalarClient.Fetch);

                options.Authentication = new ScalarAuthenticationOptions
                {
                    PreferredSecurityScheme = "Bearer"
                };
            });

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
