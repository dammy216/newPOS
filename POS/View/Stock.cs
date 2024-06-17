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
    public partial class Stock : Form
    {
        private readonly StockManager _instance = StockManager.GetInstance();

        public Stock()
        {
            InitializeComponent();
            DisplayListView();
        }

        private void DisplayListView()
        {
            stockListView.Items.Clear();

            foreach (var stock in _instance.StockList)
            {
                var stockList = _instance.DisplayStockList(stock);

                if(stockList == null)
                    continue;

                ListViewItem item = new ListViewItem(stockList);
                stockListView.Items.Add(item);
            }
        }
    }
}
