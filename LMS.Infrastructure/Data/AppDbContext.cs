using LMS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Food> Foods{ get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>()
                .HasKey(mi => new { mi.MenuId, mi.FoodId });

            modelBuilder.Entity<MenuItem>()
                .HasOne(mi => mi.Menu)
                .WithMany(m => m.MenuItems)
                .HasForeignKey(mi => mi.MenuId)
                .OnDelete(DeleteBehavior.Cascade); // Enable cascade delete

            modelBuilder.Entity<MenuItem>()
                .HasOne(mi => mi.Food)
                .WithMany(f => f.MenuItems)
                .HasForeignKey(mi => mi.FoodId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete for Food

            modelBuilder.Entity<Food>()
                .Property(f => f.FoodType)
                .HasConversion<string>();
        }

    }
}
