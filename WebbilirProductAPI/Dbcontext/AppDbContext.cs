using Microsoft.EntityFrameworkCore;
using WebbilirProductAPI.Models;

namespace WebbilirProductAPI.Dbcontext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}