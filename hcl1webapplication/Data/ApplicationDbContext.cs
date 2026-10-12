
using Microsoft.EntityFrameworkCore;
using hcl1webapplication.Models;

namespace hcl1webapplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FoodItem> FoodItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FoodItem>()
                .Property(f => f.Price)
                .HasPrecision(10, 2);
        }
    }
}
