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
    public class PriceSourceControllerTest : ControllerBase
    {
        private readonly PriceSourceController _priceSourceController;
        private readonly Mock<IPriceSourceRepository> _priceSourceRepository = new Mock<IPriceSourceRepository>();
        public PriceSourceControllerTest()
        {
            _priceSourceController = new PriceSourceController(_priceSourceRepository.Object);
        }
        [Fact]
        public async Task GetPriceSources_ReturnsTrue()
        {
            //Act
            IActionResult response = await _priceSourceController.GetPriceSources();
            var result = response as ObjectResult;
            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
