using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockApp.API.Models;
using StockApp.API.Context;

namespace StockApp.API.Repositories
{
    public class PriceSourceTickerRepository : IPriceSourceTickerRepository
    {
        private readonly StockAppContext _context;
        public PriceSourceTickerRepository(StockAppContext context)
        {
            _context = context;
        }

        public async Task<PriceSource_Ticker> Create(PriceSource_Ticker priceSource_Ticker)
        {
            var ticker = _context
                .Tickers
                .FirstOrDefault(t => t.Id == priceSource_Ticker.TickerId);
            var priceSource = _context
                .PriceSources
                .FirstOrDefault(p => p.Id == priceSource_Ticker.PriceSourceId);
            if (ticker == null)
            {
                throw new Exception("Invalid Ticker Id");
            }
            if (priceSource == null)
            {
                throw new Exception("Invalid Price Source Id");
            }

            _context.PriceSources_Tickers.Add(priceSource_Ticker);
            await _context.SaveChangesAsync();
            return priceSource_Ticker;
        }

        public async Task<String> Generate()
        {
            try
            {
                Random random = new Random();

                var tickerIds = _context.Tickers.Select(t => t.Id).ToArray();
                var priceSourceIds = _context.PriceSources.Select(p => p.Id).ToArray();

                for (int i = 0; i < 20; i++)
                {
                    int tickerIndex = random.Next(0, 6);
                    int priceSourceIndex = random.Next(0, 6);
                    double priceIndex = random.NextDouble() * 100;

                    PriceSource_Ticker priceSource_Ticker = new PriceSource_Ticker
                    {
                        Price = (float)priceIndex,
                        TickerId = tickerIds[tickerIndex],
                        PriceSourceId = priceSourceIds[priceSourceIndex],
                        CreatedAt = DateTime.UtcNow
                    };
                    _context.PriceSources_Tickers.Add(priceSource_Ticker);
                }
                await _context.SaveChangesAsync();
                return "Success";
            }
            catch
            {
                return "Failed";
            }
        }

        public async Task<List<PriceSource_Ticker>> Get(int priceSourceId, int tickerId)
        {
            return await _context
                .PriceSources_Tickers
                .Where(pt => pt.PriceSourceId == priceSourceId && pt.TickerId == tickerId)
                .OrderByDescending(pt => pt.CreatedAt)
                .Take(5)
                .ToListAsync();
        }
    }
}
