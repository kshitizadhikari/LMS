using LMS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Lunch> Lunches { get; set; }
        public DbSet<LunchDetail> LunchDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(p =>
            {
                p.HasOne(p => p.LunchDetail)
                .WithMany(ld => ld.Persons)
                .HasForeignKey(p => p.LunchDetailId);
            });
        }
    }
}
