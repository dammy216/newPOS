using POS.Model.Managers;
using POS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Main : Form
    {
        private SelesManager _selesInstance = SelesManager.GetInstance();

        public Main()
        {
            InitializeComponent();
            DisplayTodaySelesListView();
        }
        private void DisplayTodaySelesListView()
        {
            todaySalesListView.Items.Clear();

            foreach (var sales in _selesInstance.SalledList)
            {
                var selesList = _selesInstance.DisplayTodaySalesStatus(sales);

                if (selesList == null)
                    continue;

                ListViewItem item = new ListViewItem(selesList);

                todaySalesListView.Items.Add(item);
            }
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            var subscribe = new Subscribe();
            subscribe.ShowDialog();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            var purchase = new Purchase();
            purchase.ShowDialog();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            var stock = new Stock();
            stock.ShowDialog();
        }

        private void sallesButton_Click(object sender, EventArgs e)
        {
            var sales = new Seles();
            if (sales.ShowDialog() == DialogResult.OK)
            {
                DisplayTodaySelesListView();
                totalPriceLabel.Text = _selesInstance.CalcSelledTodayPrice().ToString();
            }
        }

        private void salesStatusButton_Click(object sender, EventArgs e)
        {
            var status = new TotalSales();
            status.ShowDialog();
        }
    }
}
