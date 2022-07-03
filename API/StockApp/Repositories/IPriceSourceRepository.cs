using System;
using StockApp.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.API.Repositories
{
    public interface IPriceSourceRepository
    {
        Task<IEnumerable<PriceSource>> Get();
    }
}
