using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    // This class is used to connect to the database
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) // Inherits from DbContext
        {
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}