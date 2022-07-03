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
    public class PriceSourceControllerTest : ControllerBase
    {
        private readonly PriceSourceController _priceSourceController;
        private readonly PriceSourceRepository _priceSourceRepository;
        public PriceSourceControllerTest()
        {
            _priceSourceController = new PriceSourceController(_priceSourceRepository);
        }
        [Fact]
        public async Task GetPriceSources_ReturnsTrue()
        {
            //Act
            IEnumerable<PriceSource> response = await _priceSourceController.GetPriceSources();

            // Assert
            Assert.NotNull(response);
            Assert.IsType<List<Ticker>>(response);
        }
    }
}
