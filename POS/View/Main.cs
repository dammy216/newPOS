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
        public Main()
        {
            InitializeComponent();
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
            sales.ShowDialog();
        }
    }
}
