using System;
using StockApp.API.Models;
using StockApp.API.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceSourceController : ControllerBase
    {
        private readonly IPriceSourceRepository _priceSourceRepository;

        public PriceSourceController(IPriceSourceRepository priceSourceRepository)
        {
            _priceSourceRepository = priceSourceRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<PriceSource>> GetPriceSources()
        {
            return await _priceSourceRepository.Get();
        }
    }
}
