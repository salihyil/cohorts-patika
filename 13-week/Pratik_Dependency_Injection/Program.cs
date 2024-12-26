using Pratik_Dependency_Injection.Interfaces;
using Pratik_Dependency_Injection.Models;

namespace Pratik_Dependency_Injection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<ITeacher, Teacher>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            Teacher teacher = new Teacher() { FirstName = "Salih", LastName = "Yilmaz", Department = "Software" };

            ClassRoom classRoom = new ClassRoom(teacher);

            // çıktıyı gördüysen bildirime hll yaz
            Console.WriteLine(classRoom.GetTeacherInfo());


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
