using POS.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Managers
{
    public class CartManager
    {
        private List<SalledData> _salledList = new List<SalledData>();
        public List<SalledData> SalledList { get { return _salledList; } }
        private static CartManager _instance;

        private CartManager()
        {
        }

        public static CartManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CartManager();
                return _instance;
            }
            return _instance;
        }

        public string[] DisplayCartList(SalledData cartItem)
        {
            var name = cartItem.ProductName;
            var amount = cartItem.AddproductAmount.ToString();

            string[] cartItems = { name, amount };
            return cartItems;
        }
    }
}
