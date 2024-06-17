using POS.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace POS.Model.Managers
{
    public class StockManager
    {
        private List<StockData> _stockList = new List<StockData>();
        public List<StockData> StockList { get { return _stockList; } }
        private static StockManager _instance;

        private StockManager()
        {
        }

        public static StockManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StockManager();
                return _instance;
            }
            return _instance;
        }

        public bool AddStock(string stockName, int stockAmount, int purchasePrice, int sallesPrice)
        {
            if(_stockList.Any(item => item.PurchaseName == stockName && item.StockAmount > 0))
                return true;
            
            var stockData = new StockData(stockName, stockAmount, purchasePrice, sallesPrice);
            _stockList.Add(stockData);
            return false;
        }

        public string[] DisplayStockList(StockData stock)
        {
            var name = stock.PurchaseName;
            var date = stock.PurchaseDate.ToString();
            var purchasePrice = stock.PurchasePrice.ToString();
            var sallesPrice = stock.SallesPrice.ToString();
            var amount = stock.StockAmount.ToString();

            string[] stocks = {name, date, purchasePrice, sallesPrice, amount};
            return stocks;
        }

        public string[] DisplaySelesList(StockData selesItem)
        {
            if (selesItem.StockAmount == 0)
                return null;

            var name = selesItem.PurchaseName;
            var amount = selesItem.StockAmount.ToString();

            string[] selesItems = { name, amount };
            return selesItems;
        }

        public bool IsSelectItem(int count)
        {
            if (count == 0)
                return true;

            else return false;
        }

        public bool IsZero(int amount, int purchasePrice, int sellesPrice)
        {
            if (amount == 0 || purchasePrice == 0 || sellesPrice == 0)
                return true;

            return false;
        }
    }
}
