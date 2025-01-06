using Microsoft.EntityFrameworkCore;
using Pratik_Jwt.Models;

namespace Pratik_Jwt.Contexts
{
    public class JwtDbContext : DbContext
    {
        public JwtDbContext(DbContextOptions<JwtDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
