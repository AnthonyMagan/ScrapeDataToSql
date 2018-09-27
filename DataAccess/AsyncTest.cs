using HtmlAgilityPack;
using HtmlScrapeDataToSqlTable.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlScrapeDataToSqlTable.DataAccess
{
    public class AsyncTest
    {
        public static async Task<List<string>> CallingAsync()
        {
            HtmlWeb web = new HtmlWeb();

            string url = "https://coinmarketcap.com/currencies/vechain/historical-data/";

            var doc = await Task.Factory.StartNew(() => web.Load(url));

            var dateNode = doc.DocumentNode.SelectNodes("//*[@id=\"historical-data\"]//div//div//table//tr");
            List<string> dates = dateNode.Select(node => node.InnerText).ToList();

            return dates;
        }

        public static List<DohlcModel> ConvertDatesToDohlcModel(List<DohlcModel> dohlcValues, List<string> dates)
        {
            List<DohlcModel> output = new List<DohlcModel>();

            dates.RemoveAt(0);

            foreach (string line in dates)
            {
                string[] cols = line.Split('\n');
                DohlcModel p = new DohlcModel
                {
                    Dates = cols[1],
                    PriceOpen = cols[2],
                    PriceHigh = cols[3],
                    PriceLow = cols[4],
                    PriceClose = cols[5],
                    Volume = cols[6],
                    MarketCap = cols[7]
                };

                output.Add(p);
            }

            return output;
        }
    }
}
