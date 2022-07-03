using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockApp.API.Repositories;
using StockApp.API.Models;
using System.Net;

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
        public async Task<IActionResult> GetTickers(int priceSourceId, int tickerId)
        {
            try
            {
                var result = await _priceSourceTickerRepository.Get(priceSourceId, tickerId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreatePriceSourceTicker(PriceSource_Ticker priceSource_Ticker)
        {
            try
            {
                var result = await _priceSourceTickerRepository.Create(priceSource_Ticker);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("Generate")]
        public async Task<IActionResult> GeneratePriceSource()
        {
            try
            {
                var result = await _priceSourceTickerRepository.Generate();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
