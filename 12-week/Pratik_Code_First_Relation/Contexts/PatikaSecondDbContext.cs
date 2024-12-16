using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pratik_Code_First_Relation.Entities;

namespace Pratik_Code_First_Relation.Contexts
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PostEntity> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User -> Posts relationship configuration
            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Post -> User relationship configuration
            modelBuilder.Entity<PostEntity>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Additional configurations for UserEntity
            modelBuilder.Entity<UserEntity>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<UserEntity>()
                .Property(u => u.Email)
                .IsRequired();

            // Additional configurations for PostEntity
            modelBuilder.Entity<PostEntity>()
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<PostEntity>()
                .Property(p => p.Content)
                .IsRequired();
        }
    }
}