using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        
        public DbSet<Location> Locations { get; set; }
    }
}