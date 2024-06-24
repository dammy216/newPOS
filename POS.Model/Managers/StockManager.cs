using POS.Model.Model;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace POS.Model.Managers
{
    public class StockManager
    {
        private List<StockData> _stockList = new List<StockData>();
        private List<StockData> _uniqueStockList = new List<StockData>();
        public List<StockData> StockList { get { return _stockList; } }
        public List<StockData> UniqueList {  get { return _uniqueStockList; } }
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

        //重複可能なストックリストに格納する
        public void AddStock(string stockName, int stockAmount, int purchasePrice, int sallesPrice)
        {
            var productData = new ProductData(stockName);
            var stockData = new StockData(productData, stockAmount, purchasePrice, sallesPrice);
            _stockList.Add(stockData);
        }

        //重複不可能なストックリストに格納する
        public void AddUniqueStock(string stockName, int stockAmount, int purchasePrice, int sallesPrice)
        {
            var sameProduct = _uniqueStockList.FirstOrDefault(item => item.StockProductData.ProductName == stockName && item.SallesPrice == sallesPrice);

            if(sameProduct == null)
            {
                var productData = new ProductData(stockName);
                var stockData = new StockData(productData, stockAmount, purchasePrice, sallesPrice);
                _uniqueStockList.Add(stockData);
            }
            else
            {
                sameProduct.StockAmount += stockAmount;
            }
        }

        public string[] DisplayStockList(StockData stock)
        {
            var name = stock.StockProductData.ProductName;
            var date = stock.PurchaseDate.ToString();
            var purchasePrice = stock.PurchasePrice.ToString();
            var sallesPrice = stock.SallesPrice.ToString();
            var amount = stock.StockAmount.ToString();

            string[] stocks = {name, date, purchasePrice, sallesPrice, amount};
            return stocks;
        }

        //販売画面の表示用
        public string[] DisplaySelesList(StockData selesItem)
        {
            if (selesItem.StockAmount == 0)
                return null;

            var name = selesItem.StockProductData.ProductName;
            var price = selesItem.SallesPrice.ToString();
            var amount = selesItem.StockAmount.ToString();

            string[] selesItems = { name, price, amount };
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

        public void SellesFromStock(StockData stockData, int amount)
        {
            if (amount < 0)
                return;

            var sameStockName = _stockList.FirstOrDefault(item => item == stockData);
            var sameUniqueStockName = _uniqueStockList.FirstOrDefault(item => item.StockProductData.ProductName == stockData.StockProductData.ProductName && item.SallesPrice == stockData.SallesPrice);

            if (sameStockName == null || sameStockName.StockAmount < amount || sameUniqueStockName == null || sameUniqueStockName.StockAmount < amount)
                return;

            sameStockName.StockAmount -= amount;
            sameUniqueStockName.StockAmount -= amount;
        }

        public StockData GetStockData(int index)
        {
            return _stockList[index];
        }
    }
}
