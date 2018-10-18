using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class ProductService : IProduct
    {
        //Prisijungimas prie SQL database(nzn visko gerai, bet cia conenction yra užmesgamas)
        private readonly DbContext _ctx;

        public ProductService(ProductDbContext ctx)
        {
            _ctx = ctx;
        }
    }
}