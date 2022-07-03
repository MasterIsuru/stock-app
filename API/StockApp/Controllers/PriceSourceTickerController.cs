using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockApp.API.Repositories;
using StockApp.API.Models;

namespace StockApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceSourceTickerController : ControllerBase
    {
        private readonly IPriceSourceTickerRepository _priceSourceTickerRepository;
        public PriceSourceTickerController(IPriceSourceTickerRepository priceSourceTickerRepository)
        {
            _priceSourceTickerRepository = priceSourceTickerRepository;
        }
        [HttpGet("{priceSourceId}/{tickerId}")]
        public async Task<List<PriceSource_Ticker>> GetTickers(int priceSourceId, int tickerId)
        {
            return await _priceSourceTickerRepository.Get(priceSourceId, tickerId);
        }
        [HttpPost]
        public async Task<PriceSource_Ticker> CreatePriceSourceTicker(PriceSource_Ticker priceSource_Ticker)
        {
            return await _priceSourceTickerRepository.Create(priceSource_Ticker);
        }
        [HttpGet("Generate")]
        public async Task<String> GeneratePriceSource()
        {
            return await _priceSourceTickerRepository.Generate();
        }
    }
}
