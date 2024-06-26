﻿using POS.Model.Managers;
using POS.Model.Model;
using System;
using System.Collections;
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
        private SelesManager _selesInstance = SelesManager.GetInstance();
        private CartManager _cartInstance = CartManager.GetInstance();
        public Seles()
        {
            InitializeComponent();
            DisplaySelesListView();
        }

        private void DisplaySelesListView()
        {
            salesListView.Items.Clear();

            foreach (var stock in _stockInstance.UniqueList)
            {
                var selesList = _stockInstance.DisplaySelesList(stock);

                if (selesList == null)
                    continue;

                ListViewItem item = new ListViewItem(selesList);
                salesListView.Items.Add(item);
            }
        }

        private void DisplayCartListView()
        {
            cartListView.Items.Clear();

            foreach(var cart in _cartInstance.CartList)
            {
                var cartList = _cartInstance.DisplayCartList(cart);

                if(cartList == null)
                    continue;
                
                ListViewItem item = new ListViewItem(cartList);
                cartListView.Items.Add(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (salesListView.SelectedItems.Count == 0)
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "商品が選択されていません";
                return;
            }
            else if (amountNB.Value == 0)
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "0の値があります";
                return;
            }

            messageText.ForeColor = Color.Green;
            messageText.Text = "カートに追加しました！";

            var productName = salesListView.SelectedItems[0].Text;
            var amount = (int)amountNB.Value;

            _cartInstance.AddCart(productName, amount);
            _stockInstance.SellesFromStock(productName, amount);
            DisplayCartListView();
            DisplaySelesListView();

            amountNB.Value = 0;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            foreach(var cart in  _cartInstance.CartList)
            {
                var stockData = _stockInstance.GetStockData(cart.Name);
                _selesInstance.AddSeles(stockData, cart.Amount);
            }
                _cartInstance.CartList.Clear();
                DisplayCartListView();
                DialogResult = DialogResult.OK;
        }
    }
}
