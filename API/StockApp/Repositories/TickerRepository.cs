using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockApp.API.Models;
using StockApp.API.Context;

namespace StockApp.API.Repositories
{
    public class TickerRepository : ITickerRepository
    {
        private readonly StockAppContext _context;

        public TickerRepository(StockAppContext context)
        {
            _context = context;
        }
        public async Task<List<Ticker>> Get(int priceSourceId)
        {
            var priceSource_Tickers = _context
                .PriceSources_Tickers
                .Where(pt => pt.PriceSourceId == priceSourceId)
                .Select(x => x.TickerId)
                .Distinct()
                .ToArray();
            return await _context
                .Tickers
                .Where(t => priceSource_Tickers.Contains(t.Id))
                .ToListAsync();
        }
    }
}
