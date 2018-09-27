using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HtmlScrapeDataToSqlTable.Models;

namespace HtmlScrapeDataToSqlTable.DataAccess
{
    class SqlConnector
    {
        internal static void InsertDohlcValuesToSql(List<DohlcModel> model)
        {            
            // using statement because when we go out of scope it will close the connection. Good practice to ensure connection is closed
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WatchListDB")))
            {
                // Dates, PriceOpen, PriceHigh, PriceLow, PriceClose, Volume, MarketCap 
                foreach (var  value in model)
                {
                    var p = new DynamicParameters();

                    p.Add("@Dates", value.Dates);
                    p.Add("@PriceOpen", value.PriceOpen);
                    p.Add("@PriceHigh", value.PriceHigh);
                    p.Add("@PriceLow", value.PriceLow);
                    p.Add("@PriceClose", value.PriceClose);
                    p.Add("@Volume", value.Volume);
                    p.Add("@MarketCap", value.MarketCap);

                    //Created stored procedure, dbo.spTest1_Insert
                    connection.Execute("dbo.spTest1_Insert", p, commandType: CommandType.StoredProcedure);
                }

            }
        }
    }
}
