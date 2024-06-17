using POS.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        //同じ名前があったらエラーを返す用
        public bool AddCart(string productName, int productAmount)
        {
            if (_cartList.Any(item => item.ProductName == productName))
                return true;

            var productData = new CartData(productName, productAmount);
            _cartList.Add(productData);
            return false;
        }

        public bool IsSelectItem(int count)
        {
            if (count == 0)
                return true;

            else return false;
        }

        public bool IsZero(int amount)
        {
            if (amount == 0)
                return true;

            return false;
        }

        public string[] DisplayCartList(CartData cartItem)
        {
            var name = cartItem.ProductName;
            var amount = cartItem.AddproductAmount.ToString();

            string[] cartItems = { name, amount };
            return cartItems;
        }
    }
}
