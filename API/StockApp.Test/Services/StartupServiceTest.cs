using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockApp.API;
using StockApp.API.Repositories;
using Xunit;

namespace StockApp.Test.Services
{
    public class StartupServiceTest : IDisposable
    {
        private readonly TestServer _testServer;

        public StartupServiceTest()
        {
            var configuration = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                                   .AddEnvironmentVariables()
                                   .AddJsonFile("appsettings.json")
                                   .Build();

            var webBuilder = new WebHostBuilder().UseConfiguration(configuration).UseStartup<Startup>();
            _testServer = new TestServer(webBuilder);
        }

        [Fact]
        public void StartupTest()
        {
            Assert.NotNull(_testServer);
            Assert.NotNull(_testServer.Services.GetRequiredService<ITickerRepository>());
        }

        public void Dispose()
        {
            _testServer.Dispose();
        }
    }
}
