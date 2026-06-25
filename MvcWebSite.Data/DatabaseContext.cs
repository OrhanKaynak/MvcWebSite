using Microsoft.EntityFrameworkCore;
using MvcWebSite.Core.Entities;

namespace MvcWebSite.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=MVCWebSite; integrated security=true; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    Name = "Test",
                    Email = "admin.yahoo.co",
                    IsActive = true,
                    IsAdmin = true,
                    Password = "Pass123"
                });
        }
    }
}
