using POS.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Managers
{
    public class CartManager
    {
        private List<CartData> _cartList = new List<CartData>();
        public List<CartData> CartList { get { return _cartList; } }
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

        public void AddCart(string productName, int productAmount)
        {
            var sameProduct = _cartList.FirstOrDefault(item => item.Name == productName);

            if (sameProduct != null)
            {
                sameProduct.Amount += productAmount;
            }
            else
            {
                var cart = new CartData(productName, productAmount);
                _cartList.Add(cart);
            }
        }

        public string[] DisplayCartList(CartData cart)
        {
            var name = cart.Name;
            var amount = cart.Amount.ToString();

            string[] cartrItems = { name, amount };
            return cartrItems;
        }
    }
}
