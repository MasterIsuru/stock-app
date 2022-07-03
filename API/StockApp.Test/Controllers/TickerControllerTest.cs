using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockApp.API.Controllers;
using StockApp.API.Models;
using StockApp.API.Repositories;
using Xunit;

namespace StockApp.Test.Controllers
{
    public class TickerControllerTest : ControllerBase
    {
        private readonly TickerController _tickerController;
        private readonly TickerRepository _tickerRepository;
        public TickerControllerTest()
        {
            _tickerController = new TickerController(_tickerRepository);
        }
        [Fact]
        public async Task GetTickers_ReturnsTrue()
        {
            //Act
            List<Ticker> response = await _tickerController.GetTickers(1);

            // Assert
            Assert.NotNull(response);
            Assert.IsType<List<Ticker>>(response);
        }
    }
}
