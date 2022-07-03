using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockApp.API.Models;
using StockApp.API.Context;

namespace StockApp.API.Repositories
{
    public class PriceSourceRepository : IPriceSourceRepository
    {
        private readonly StockAppContext _context;

        public PriceSourceRepository(StockAppContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PriceSource>> Get()
        {
            return await _context.PriceSources.ToListAsync();
        }
    }
}
