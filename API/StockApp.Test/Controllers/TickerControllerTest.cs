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
using Moq;

namespace StockApp.Test.Controllers
{
    public class TickerControllerTest : ControllerBase
    {
        private readonly TickerController _tickerController;
        private readonly Mock<ITickerRepository> _tickerRepository = new Mock<ITickerRepository>();
        public TickerControllerTest()
        {
            _tickerController = new TickerController(_tickerRepository.Object);
        }
        [Fact]
        public async Task GetTickers_ReturnsTrue()
        {
            //Act
            IActionResult response = await _tickerController.GetTickers(1);
            var result = response as ObjectResult;
            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.IsType<OkObjectResult>(response);
        }
    }
}
