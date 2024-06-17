namespace POS.View
{
    partial class Purchase
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
            this.productNameListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.amountNB = new System.Windows.Forms.NumericUpDown();
            this.purchasePriceNB = new System.Windows.Forms.NumericUpDown();
            this.SellesPriceNB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasePriceNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellesPriceNB)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameListView
            // 
            this.productNameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.productNameListView.HideSelection = false;
            this.productNameListView.Location = new System.Drawing.Point(70, 63);
            this.productNameListView.Name = "productNameListView";
            this.productNameListView.Size = new System.Drawing.Size(116, 298);
            this.productNameListView.TabIndex = 0;
            this.productNameListView.UseCompatibleStateImageBehavior = false;
            this.productNameListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 100;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(297, 338);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // amountNB
            // 
            this.amountNB.Location = new System.Drawing.Point(287, 80);
            this.amountNB.Name = "amountNB";
            this.amountNB.Size = new System.Drawing.Size(120, 19);
            this.amountNB.TabIndex = 2;
            // 
            // purchasePriceNB
            // 
            this.purchasePriceNB.Location = new System.Drawing.Point(287, 155);
            this.purchasePriceNB.Name = "purchasePriceNB";
            this.purchasePriceNB.Size = new System.Drawing.Size(120, 19);
            this.purchasePriceNB.TabIndex = 3;
            // 
            // SellesPriceNB
            // 
            this.SellesPriceNB.Location = new System.Drawing.Point(287, 240);
            this.SellesPriceNB.Name = "SellesPriceNB";
            this.SellesPriceNB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SellesPriceNB.Size = new System.Drawing.Size(120, 19);
            this.SellesPriceNB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "仕入数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "仕入価格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "販売価格";
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.ForeColor = System.Drawing.Color.Red;
            this.messageText.Location = new System.Drawing.Point(287, 296);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(0, 12);
            this.messageText.TabIndex = 8;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 423);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellesPriceNB);
            this.Controls.Add(this.purchasePriceNB);
            this.Controls.Add(this.amountNB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productNameListView);
            this.Name = "Purchase";
            this.Text = "Purches";
            ((System.ComponentModel.ISupportInitialize)(this.amountNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasePriceNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellesPriceNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView productNameListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown amountNB;
        private System.Windows.Forms.NumericUpDown purchasePriceNB;
        private System.Windows.Forms.NumericUpDown SellesPriceNB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label messageText;
    }
}