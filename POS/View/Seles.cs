using POS.Model.Managers;
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


        private void buyButton_Click(object sender, EventArgs e)
        {
            if(salesListView.SelectedItems.Count == 0)
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "商品が選択されていません";
                return;
            }
            else if(amountNB.Value == 0)
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "0の値があります";
                return;
            }
            else
            {
                messageText.ForeColor = Color.Green;
                messageText.Text = "商品を購入しました！";

                var amount = (int)amountNB.Value;
                var selectStockData = _stockInstance.GetStockData(salesListView.SelectedItems[0].Index);

                _selesInstance.AddSeles(selectStockData, amount);
                _stockInstance.SellesFromStock(selectStockData, amount);

                DisplaySelesListView();
                DialogResult = DialogResult.OK;
                amountNB.Value = 0;
            };
        }
    }
}
