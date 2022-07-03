using Microsoft.EntityFrameworkCore;
using System;
using StockApp.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockApp.API.Helpers;

namespace StockApp.API.Context
{
    public class StockAppContext : DbContext
    {
        public StockAppContext(DbContextOptions<StockAppContext> options)
            : base(options)
        {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<PriceSource> PriceSources { get; set; }
        public DbSet<Ticker> Tickers { get; set; }
        public DbSet<PriceSource_Ticker> PriceSources_Tickers { get; set; }
    }
}
