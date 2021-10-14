
namespace StockApp
{
    partial class FrmAdd
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.tbxStockAmount);
            this.groupBox2.Controls.Add(this.tbxUnitPrice);
            this.groupBox2.Controls.Add(this.tbxProductName);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.lblStockAmount);
            this.groupBox2.Controls.Add(this.lblUnitPrice);
            this.groupBox2.Location = new System.Drawing.Point(22, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 247);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Ürün";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ürünü Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(128, 134);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(164, 20);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(128, 95);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(164, 20);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(128, 49);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(164, 20);
            this.tbxProductName.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(38, 57);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(38, 141);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(29, 13);
            this.lblStockAmount.TabIndex = 2;
            this.lblStockAmount.Text = "Stok";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(38, 102);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 288);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmAdd";
            this.Text = "Ürün Ekleme";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
    }
}