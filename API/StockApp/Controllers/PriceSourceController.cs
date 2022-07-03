using System;
using StockApp.API.Models;
using StockApp.API.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public async Task<IActionResult> GetPriceSources()
        {
            try
            {
                var result = await _priceSourceRepository.Get();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
