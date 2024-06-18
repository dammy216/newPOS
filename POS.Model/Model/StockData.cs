using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Model
{
    public class StockData
    {
        public ProductData StockProductData {  get; set; }
        public string PurchaseDate { get; set; }
        public int PurchasePrice {  get; set; }
        public int SallesPrice {  get; set; }
        public int StockAmount { get; set; }

        public StockData(ProductData product, int stockAmount ,int purchasePrice, int sallesPrice )
        {
            StockProductData = product;
            PurchaseDate = DateTime.Today.ToString("yyyy-MM-dd");
            PurchasePrice = purchasePrice;
            SallesPrice = sallesPrice;
            StockAmount = stockAmount;
        }
    }
}
