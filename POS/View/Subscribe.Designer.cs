namespace POS.View
{
    partial class Subscribe
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
            this.subscribeButton = new System.Windows.Forms.Button();
            this.productTB = new System.Windows.Forms.TextBox();
            this.messageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(61, 138);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(75, 23);
            this.subscribeButton.TabIndex = 0;
            this.subscribeButton.Text = "登録";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // productTB
            // 
            this.productTB.Location = new System.Drawing.Point(48, 74);
            this.productTB.Name = "productTB";
            this.productTB.Size = new System.Drawing.Size(100, 19);
            this.productTB.TabIndex = 1;
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.ForeColor = System.Drawing.Color.Red;
            this.messageText.Location = new System.Drawing.Point(46, 96);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(0, 12);
            this.messageText.TabIndex = 2;
            // 
            // Subscribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 189);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.productTB);
            this.Controls.Add(this.subscribeButton);
            this.Name = "Subscribe";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.TextBox productTB;
        private System.Windows.Forms.Label messageText;
    }
}