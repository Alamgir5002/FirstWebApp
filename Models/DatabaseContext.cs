using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(model => model.UserId).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().HasIndex(model => model.Email).IsUnique();
        }
        public DbSet<User> Users { get; set; } = default!;
    }
}
