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
    public partial class TotalSales : Form
    {
        private SelesManager _selesInstance = SelesManager.GetInstance();

        public TotalSales()
        {
            InitializeComponent();
            DisplayTotalSelesListView();
            totalPriceLabel.Text = _selesInstance.CalcSalledTotalPrice().ToString();
            totalProfitLabel.Text = _selesInstance.CalcProfitTotalPrice().ToString();
        }

        private void DisplayTotalSelesListView()
        {
            totalSalesListView.Items.Clear();

            foreach (var sales in _selesInstance.SalledList)
            {
                var selesList = _selesInstance.DisplayTotalSalesStatus(sales);

                if (selesList == null)
                    continue;

                ListViewItem item = new ListViewItem(selesList);

                totalSalesListView.Items.Add(item);
            }
        }
    }
}
