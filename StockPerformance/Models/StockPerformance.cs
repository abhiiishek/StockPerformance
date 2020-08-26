using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockPerformance.Models
{
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
