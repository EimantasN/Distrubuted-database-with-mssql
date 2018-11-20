using Microsoft.EntityFrameworkCore;
using ProductData.Models;
using SellerData.SellerModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SellerData
{
    public class SellerDbContext : DbContext
    {
        public SellerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SellerItem> SellerItems { get; set; }
        public DbSet<Rating> SellerRating { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
