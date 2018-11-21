using Microsoft.EntityFrameworkCore;
using SellerData.Models;
using SellerData.SellerModels;

namespace SellerData
{
    public class SellerDbContext : DbContext
    {
        public SellerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SellerModels.Item> Products { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
