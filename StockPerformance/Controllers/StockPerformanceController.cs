using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;
using StockPerformance.Models;

namespace StockPerformance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockPerformanceController : ControllerBase
    {
        [HttpGet]
        
        public IEnumerable<StockPerformance> getStockPerformanceReport()
        {
            using (StreamReader r = new StreamReader("./wwwroot/assets/data/StockPerformance.json"))
            {
                string json = r.ReadToEnd();
                List<StockPerformance> stockList = JsonConvert.DeserializeObject<List<StockPerformance>>(json);
                return stockList;
            }

        }

        public class StockPerformance
        {
            public string company { get; set; }
            public string description { get; set; }
            public decimal initial_price { get; set; }
            public decimal price_2002 { get; set; }
            public decimal price_2007 { get; set; }
            public string symbol { get; set; }

        }
    }
}