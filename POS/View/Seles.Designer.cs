namespace POS.View
{
    partial class Seles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountNB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.cartListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNB)).BeginInit();
            this.SuspendLayout();
            // 
            // salesListView
            // 
            this.salesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.salesListView.HideSelection = false;
            this.salesListView.Location = new System.Drawing.Point(37, 79);
            this.salesListView.Name = "salesListView";
            this.salesListView.Size = new System.Drawing.Size(207, 288);
            this.salesListView.TabIndex = 0;
            this.salesListView.UseCompatibleStateImageBehavior = false;
            this.salesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "在庫数";
            this.columnHeader2.Width = 100;
            // 
            // amountNB
            // 
            this.amountNB.Location = new System.Drawing.Point(312, 181);
            this.amountNB.Name = "amountNB";
            this.amountNB.Size = new System.Drawing.Size(120, 19);
            this.amountNB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "購入数";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(325, 262);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(325, 344);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "購入";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // cartListView
            // 
            this.cartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.cartListView.HideSelection = false;
            this.cartListView.Location = new System.Drawing.Point(517, 79);
            this.cartListView.Name = "cartListView";
            this.cartListView.Size = new System.Drawing.Size(210, 288);
            this.cartListView.TabIndex = 5;
            this.cartListView.UseCompatibleStateImageBehavior = false;
            this.cartListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品名";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "購入数";
            this.columnHeader4.Width = 100;
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Location = new System.Drawing.Point(312, 207);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(0, 12);
            this.messageText.TabIndex = 6;
            // 
            // Seles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 454);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.cartListView);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountNB);
            this.Controls.Add(this.salesListView);
            this.Name = "Seles";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.amountNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView salesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.NumericUpDown amountNB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.ListView cartListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label messageText;
    }
}