using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Model
{
    public class SalledData
    {
        public string SalledProductName {  get; set; }
        public int SalledPrice { get; set; }
        public int SalledAmount {  get; set; }
        public int SalledSubTotal {  get; set; }
        public string SalledDate { get; set; }

        public SalledData(string salledProductName, int salledPrice, int salledAmount, int salledSubTotal)
        {
            SalledProductName = salledProductName;
            SalledPrice = salledPrice;
            SalledAmount = salledAmount;
            SalledSubTotal = salledSubTotal;
            SalledDate = DateTime.Today.ToString("yyyy-MM-dd");
        }

    }
}
