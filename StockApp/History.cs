using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class History
    {
        public int HistoryId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int StockAmount { get; set; }
        public decimal SumPrice { get; set; }
        public string Date { get; set; }
    }
}
