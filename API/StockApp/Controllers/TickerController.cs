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
    public class TickerController : ControllerBase
    {
        private readonly ITickerRepository _tickerRepository;

        public TickerController(ITickerRepository tickerRepository)
        {
            _tickerRepository = tickerRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTickers(int id)
        {
            try
            {
                var result = await _tickerRepository.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
