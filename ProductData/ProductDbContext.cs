
using Microsoft.EntityFrameworkCore;
using ProductData.Models;
using ProductData.ProductModels;

namespace ProductData
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>()
                .HasIndex(u => u.Created)
                .IsUnique();

            builder.Entity<Item>().HasAlternateKey(u => u.Created);


        }

        public DbSet<Item> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ImageSource> Images { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<Log> Logs { get; set; }
    }
}