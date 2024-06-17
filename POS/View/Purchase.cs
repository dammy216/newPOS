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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS.View
{
    
    public partial class Purchase : Form
    {
        private readonly ProductManager _productInstance = ProductManager.GetInstance();
        private readonly StockManager _stockInstance = StockManager.GetInstance();
        public Purchase()
        {
            InitializeComponent();
            DisplayListView();
        }

        private void DisplayListView()
        {
            productNameListView.Items.Clear();
            
            foreach(var product in _productInstance.ProductList)
            {
                var productList = _productInstance.DisplaySubscribeProduct(product);

                if (productList == null)
                    continue;

                ListViewItem item = new ListViewItem(productList);
                productNameListView.Items.Add(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(_stockInstance.IsSelectItem(productNameListView.SelectedItems.Count))
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "商品が選択されていません";
                return;
            }

            var name = productNameListView.SelectedItems[0].Text;
            var amount = (int)amountNB.Value;
            var purchasePrice = (int)purchasePriceNB.Value;
            var sellesPrice = (int)SellesPriceNB.Value;

            if (_stockInstance.IsZero( amount, purchasePrice, sellesPrice))
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "0の値があります";
                return;
            }

            if (_stockInstance.AddStock(name, amount, purchasePrice, sellesPrice))
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "その商品は在庫が存在しています";
            }
            else
            {
                messageText.ForeColor = Color.Green;
                messageText.Text = "在庫に追加しました!";
            }

            amountNB.Value = 0;
            purchasePriceNB.Value = 0;
            SellesPriceNB.Value = 0;
        }

        
    }
}
