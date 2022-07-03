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
    public class TickerController : ControllerBase
    {
        private readonly ITickerRepository _tickerRepository;

        public TickerController(ITickerRepository tickerRepository)
        {
            _tickerRepository = tickerRepository;
        }

        [HttpGet("{id}")]
        public async Task<List<Ticker>> GetTickers(int id)
        {
            return await _tickerRepository.Get(id);
        }
    }
}
