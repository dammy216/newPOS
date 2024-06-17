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
    public partial class Subscribe : Form
    {
        private ProductManager _instance = ProductManager.GetInstance();
        public Subscribe()
        {
            InitializeComponent();
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            if(_instance.isEmpty(productTB.Text))
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "商品名を入力してください";
                return;
            }

            if (_instance.AddProduct(productTB.Text))
            {
                messageText.ForeColor = Color.Red;
                messageText.Text = "その商品は存在しています";
            }
            else
            {
                messageText.ForeColor = Color.Green;
                messageText.Text = "登録しました！";
            }

                productTB.Text = "";
        }

        
    }
}
