using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pratik_Survivor.Entities;

namespace Pratik_Survivor.Contexts
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Category - Competitor arasında One-to-Many (1-N) ilişki kurulumu
            modelBuilder.Entity<Category>()
                        // Bir Category'nin birden fazla Competitor'ı olabilir (1-N ilişkinin "Çok" tarafı)
                        .HasMany(c => c.Competitors)
                        // Her Competitor'ın sadece bir Category'si olabilir (1-N ilişkinin "Bir" tarafı)
                        .WithOne(c => c.Category)
                        // Competitor tablosunda CategoryId sütunu foreign key olarak kullanılacak
                        .HasForeignKey(c => c.CategoryId);

            /*  modelBuilder.Entity<Competitor>()
                         .HasOne(c => c.Category)
                         .WithMany(c => c.Competitors)
                         .HasForeignKey(c => c.CategoryId);
           */


            //seed data
            modelBuilder.Entity<Competitor>().HasData(
                new Competitor
                {
                    Id = 1,
                    FirstName = "Acun",
                    LastName = "Ilıcalı",
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 2,
                    FirstName = "Aleyna",
                    LastName = "Avcı",
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 3,
                    FirstName = "Hadise",
                    LastName = "Açıkgöz",
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 4,
                    FirstName = "Sertan",
                    LastName = "Bozkuş",
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 5,
                    FirstName = "Özge",
                    LastName = "Açık",
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 6,
                    FirstName = "Kıvanç",
                    LastName = "Tatlıtuğ",
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 7,
                    FirstName = "Ahmet",
                    LastName = "Yılmaz",
                    CategoryId = 2,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 8,
                    FirstName = "Elif",
                    LastName = "Demirtaş",
                    CategoryId = 2,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 9,
                    FirstName = "Cem",
                    LastName = "Öztürk",
                    CategoryId = 2,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Competitor
                {
                    Id = 10,
                    FirstName = "Ayşe",
                    LastName = "Karaca",
                    CategoryId = 2,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Ünlüler",
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                },
                new Category
                {
                    Id = 2,
                    Name = "Gönüllüler",
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                }
            );
        }

    }
}