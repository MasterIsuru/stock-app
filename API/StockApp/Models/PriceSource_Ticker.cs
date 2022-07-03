using System;
using StockApp.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.API.Models
{
    public class PriceSource_Ticker
    {
        public int Id { get; set; }
        public int TickerId { get; set; }
        public int PriceSourceId { get; set; }
        public float Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
