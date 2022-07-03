using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockApp.API.Models;

namespace StockApp.API.Helpers
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Price source seed
            modelBuilder.Entity<PriceSource>().HasData(
                new PriceSource
                {
                    Id = 1,
                    Name = "SRC1",
                    Description = "Source 1",
                },
                new PriceSource
                {
                    Id = 2,
                    Name = "SRC2",
                    Description = "Source 2",
                },
                new PriceSource
                {
                    Id = 3,
                    Name = "SRC3",
                    Description = "Source 3",
                },
                new PriceSource
                {
                    Id = 4,
                    Name = "SRC4",
                    Description = "Source 4",
                },
                new PriceSource
                {
                    Id = 5,
                    Name = "SRC5",
                    Description = "Source 5",
                },
                new PriceSource
                {
                    Id = 6,
                    Name = "SRC6",
                    Description = "Source 6",
                }
                );

            // Ticker seed
            modelBuilder.Entity<Ticker>().HasData(
                new Ticker
                {
                    Id = 1,
                    Name = "IBM UN",
                    Description = "IBM",
                },
                new Ticker
                {
                    Id = 2,
                    Name = "ITL SE",
                    Description = "INTEL",
                },
                new Ticker
                {
                    Id = 3,
                    Name = "SMG CC",
                    Description = "SAMSUNG",
                },
                new Ticker
                {
                    Id = 4,
                    Name = "APL US",
                    Description = "APPLE",
                },
                new Ticker
                {
                    Id = 5,
                    Name = "FBK EE",
                    Description = "FACEBOOK",
                },
                new Ticker
                {
                    Id = 6,
                    Name = "TLA RR",
                    Description = "TESLA",
                }
                );

            // Price source ticker seed
            modelBuilder.Entity<PriceSource_Ticker>().HasData(
                new PriceSource_Ticker
                {
                    Id = 1,
                    PriceSourceId = 1,
                    TickerId = 1,
                    Price = 100.44F,
                    CreatedAt = DateTime.UtcNow,
                },
                new PriceSource_Ticker
                {
                    Id = 2,
                    PriceSourceId = 1,
                    TickerId = 1,
                    Price = 103.44F,
                    CreatedAt = DateTime.UtcNow,
                },
                new PriceSource_Ticker
                {
                    Id = 3,
                    PriceSourceId = 1,
                    TickerId = 1,
                    Price = 92.11F,
                    CreatedAt = DateTime.UtcNow,
                },
                new PriceSource_Ticker
                {
                    Id = 4,
                    PriceSourceId = 1,
                    TickerId = 1,
                    Price = 110.44F,
                    CreatedAt = DateTime.UtcNow,
                },
                new PriceSource_Ticker
                {
                    Id = 5,
                    PriceSourceId = 1,
                    TickerId = 1,
                    Price = 90.54F,
                    CreatedAt = DateTime.UtcNow,
                },
                new PriceSource_Ticker
                {
                    Id = 6,
                    PriceSourceId = 1,
                    TickerId = 1,
                    Price = 109.25F,
                    CreatedAt = DateTime.UtcNow,
                }
                );
        }
    }
}
