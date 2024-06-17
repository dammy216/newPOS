using POS.Model.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.View
{
    public partial class Seles : Form
    {
        private StockManager _stockInstance = StockManager.GetInstance();
        private CartManager _cartInstance = CartManager.GetInstance();
        private SelesManager _selesInstance = SelesManager.GetInstance();
        public Seles()
        {
            InitializeComponent();
            DisplaySelesListView();
        }

        private void DisplaySelesListView()
        {
            salesListView.Items.Clear();

            foreach (var stock in _stockInstance.StockList)
            {
                var selesList = _stockInstance.DisplaySelesList(stock);

                if(selesList == null )
                    continue;

                ListViewItem item = new ListViewItem(selesList);

                salesListView.Items.Add(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (_cartInstance.IsSelectItem(salesListView.SelectedItems.Count))
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "商品が選択されていません";
                return;
            }

            var name = salesListView.SelectedItems[0].Text;
            var amount = (int)amountNB.Value;

            if (_cartInstance.IsZero(amount))
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "0の値があります";
                return;
            }

            if (_cartInstance.AddCart(name, amount))
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "その商品はカートに入っています";
            }
            else
            {
                messageText.ForeColor = Color.Green;
                messageText.Text = "カートに入れました！";
            }

            DisplayCartListView();
            amountNB.Value = 0;
        }

        private void DisplayCartListView()
        {
            cartListView.Items.Clear();

            foreach (var cartItem in _cartInstance.CartList)
            {
                var cartList = _cartInstance.DisplayCartList(cartItem);

                if (cartList == null)
                    continue;

                ListViewItem item = new ListViewItem(cartList);

                cartListView.Items.Add(item);
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            cartListView.Items.Clear();

            var stockList = _stockInstance.StockList;
            var cartList = _cartInstance.CartList;
            _selesInstance.SellesFromStock(stockList, cartList);
            DisplaySelesListView();
        }
    }
}
