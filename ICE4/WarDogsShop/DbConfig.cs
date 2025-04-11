using Microsoft.EntityFrameworkCore;
using WarDogsShop.Models;

namespace WarDogsShop 
{
    public class DbConfig : DbContext
    {
        public DbConfig(DbContextOptions<DbConfig> options)
               : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbConfig).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Product { get; set; }
    }
}
