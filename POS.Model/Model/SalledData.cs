using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Model
{
    public class SalledData
    {
        public StockData StockData { get; set; }
        public int SalledAmount {  get; set; }
        public int SalledSubTotal {  get; set; }
        public string SalledDate { get; set; }

        public SalledData(StockData stockData, int salledAmount)
        {
            StockData = stockData;
            SalledAmount = salledAmount;
            SalledSubTotal = stockData.SallesPrice * salledAmount;
            SalledDate = DateTime.Today.ToString("yyyy-MM-dd");
        }

    }
}
