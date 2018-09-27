using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlScrapeDataToSqlTable.Models
{
    public class DohlcModel
    {
        public string Dates { get; set; }
        public string PriceOpen { get; set; }
        public string PriceHigh { get; set; }
        public string PriceLow { get; set; }
        public string PriceClose { get; set; }
        public string Volume { get; set; }
        public string MarketCap { get; set; }
    }
}
