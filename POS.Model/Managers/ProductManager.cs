using POS.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Managers
{
    public class ProductManager
    {
        private List<ProductData> _productList = new List<ProductData>();
        public List<ProductData> ProductList { get {  return _productList; } }
        private static ProductManager _instance;

        private ProductManager()
        {
        }

        public static ProductManager GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ProductManager();
                return _instance;
            }
            return _instance;
        }

        public bool AddProduct(string productName)
        {
            if(_productList.Any(item => item.ProductName == productName))
                return true;

                var productData = new ProductData(productName);
                _productList.Add(productData);
                return false;
        }

        public string DisplaySubscribeProduct(ProductData product)
        {
            var name = product.ProductName;
            return name;
        }

        public bool isEmpty(string productName)
        {
            if (productName == "")
                return true;

            return false;
        }
    }
}
