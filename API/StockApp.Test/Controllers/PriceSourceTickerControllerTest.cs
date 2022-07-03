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
    public class PriceSourceTickerControllerTest : ControllerBase
    {
        private readonly PriceSourceTickerController _priceSourceTickerController;
        private readonly Mock<IPriceSourceTickerRepository> _priceSourceTickerRepository = new Mock<IPriceSourceTickerRepository>();
        public PriceSourceTickerControllerTest()
        {
            _priceSourceTickerController = new PriceSourceTickerController(_priceSourceTickerRepository.Object);
        }

        [Fact]
        public async Task GeneratePriceSource_ReturnsTrue()
        {
            //Act
            IActionResult response = await _priceSourceTickerController.GeneratePriceSource();
            var result = response as ObjectResult;
            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.IsType<OkObjectResult>(response);
        }

        [Fact]
        public async Task GetTickers_ReturnsTrue()
        {
            //Act
            IActionResult response = await _priceSourceTickerController.GetTickers(1, 1);
            var result = response as ObjectResult;
            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.IsType<OkObjectResult>(response);
        }
    }
}
