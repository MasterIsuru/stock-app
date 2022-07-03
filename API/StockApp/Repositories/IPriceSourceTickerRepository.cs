using System;
using StockApp.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.API.Repositories
{
    public interface IPriceSourceTickerRepository
    {
        Task<List<PriceSource_Ticker>> Get(int priceSourceId, int tickerId);
        Task<PriceSource_Ticker> Create(PriceSource_Ticker priceSource_Ticker);
        Task<String> Generate();
    }
}
