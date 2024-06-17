using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Model
{
    public class CartData
    {
        public string ProductName {  get; set; }
        public int AddproductAmount {  get; set; } 

        public CartData(string productName, int ProductAmount)
        {
            ProductName = productName;
            AddproductAmount = ProductAmount;
        }
    }
}
