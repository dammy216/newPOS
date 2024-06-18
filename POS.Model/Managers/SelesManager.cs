using POS.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Managers
{
    public class SelesManager
    {
        private List<SalledData> _salledList = new List<SalledData>();
        public List<SalledData> SalledList { get {  return _salledList; } }
        private static SelesManager _instance;

        private SelesManager()
        {
        }

        public static SelesManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SelesManager();
                return _instance;
            }
            return _instance;
        }

        public void AddSeles(StockData stockData, int salledAmount)
        {
            var salledData = new SalledData(stockData, salledAmount);
            _salledList.Add(salledData);
        }

        //"総"売り上げ金額を求める
        public int CalcSalledTotalPrice()
        {
            int salledTotalPrice = _salledList.Sum(item => item.SalledSubTotal);
            return salledTotalPrice;
        }

        //"今日"の売り上げ金額を求める
        public int CalcSelledTodayPrice()
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            int salledTodayPrice = _salledList.Where(item => item.SalledDate == today).Sum(item => item.SalledSubTotal);
            return salledTodayPrice;
        }

        public string[] DisplayTodaySalesStatus(SalledData sales)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            string[] salesItems = null;
            if(sales.SalledDate == today)
            {
                var name = sales.StockData.StockProductData.ProductName;
                var price = sales.StockData.SallesPrice.ToString();
                var amount = sales.SalledAmount.ToString();
                var subTotal = sales.SalledSubTotal.ToString();

                salesItems = new string[] { name, price, amount, subTotal };
            }
            return salesItems;
        }

        public string[] DisplayTotalSalesStatus(SalledData sales)
        {
            var name = sales.StockData.StockProductData.ProductName;
            var price = sales.StockData.SallesPrice.ToString();
            var amount = sales.SalledAmount.ToString();
            var subTotal = sales.SalledSubTotal.ToString();

            string[] salesItems = {name,  price, amount, subTotal};
            return salesItems;
        }

        public int CalcProfitTotalPrice()
        {
            var purchaseSubTotal = _salledList.Sum(item => item.StockData.PurchasePrice * item.SalledAmount);
            return CalcSalledTotalPrice() - purchaseSubTotal;
        }

        public int CalcProfitTodayTotalPrice()
        {
            var today = DateTime.Today.ToString("yyyy-MM-dd");
            var purchaseSubTotal = _salledList.Where(item => item.SalledDate == today).Sum(item => item.StockData.PurchasePrice * item.SalledAmount);
            return CalcSelledTodayPrice() - purchaseSubTotal;
        }
    }
}

        

