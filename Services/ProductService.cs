using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductData;
using ProductData.Models;

namespace Services
{
    public class ProductService : IProduct
    {
        //Prisijungimas prie SQL database(nzn visko gerai, bet cia conenction yra užmesgamas)
        private readonly ProductDbContext _ctx;

        public ProductService(ProductDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<Item>> GetItems()
        {
            try
            {
                return await _ctx.Products.ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}