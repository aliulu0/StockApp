
namespace StockApp
{
    partial class FrmSell
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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnSellCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxTotalPrice = new System.Windows.Forms.TextBox();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSellRemove = new System.Windows.Forms.Button();
            this.btnSellAdd = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.dgwCart = new System.Windows.Forms.DataGridView();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(363, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 16);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Tarih";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(59, 454);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(101, 23);
            this.btnSell.TabIndex = 21;
            this.btnSell.Text = "Satış";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnSellCancel
            // 
            this.btnSellCancel.Location = new System.Drawing.Point(236, 454);
            this.btnSellCancel.Name = "btnSellCancel";
            this.btnSellCancel.Size = new System.Drawing.Size(85, 23);
            this.btnSellCancel.TabIndex = 20;
            this.btnSellCancel.Text = "Satışı İptal";
            this.btnSellCancel.UseVisualStyleBackColor = true;
            this.btnSellCancel.Click += new System.EventHandler(this.btnSellCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxTotalPrice);
            this.groupBox2.Controls.Add(this.lblSumPrice);
            this.groupBox2.Controls.Add(this.tbxId);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.btnSellRemove);
            this.groupBox2.Controls.Add(this.btnSellAdd);
            this.groupBox2.Controls.Add(this.tbxStockAmount);
            this.groupBox2.Controls.Add(this.tbxUnitPrice);
            this.groupBox2.Controls.Add(this.tbxProductName);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.lblStockAmount);
            this.groupBox2.Controls.Add(this.lblUnitPrice);
            this.groupBox2.Location = new System.Drawing.Point(19, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 275);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satılacak Ürün";
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.Location = new System.Drawing.Point(150, 177);
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            this.tbxTotalPrice.Size = new System.Drawing.Size(164, 20);
            this.tbxTotalPrice.TabIndex = 12;
            this.tbxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxTotalPrice.TextChanged += new System.EventHandler(this.tbxTotalPrice_TextChanged);
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Location = new System.Drawing.Point(66, 184);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(67, 13);
            this.lblSumPrice.TabIndex = 11;
            this.lblSumPrice.Text = "Toplam Fiyat";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(150, 22);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(164, 20);
            this.tbxId.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(89, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Satılacak Ürün Id";
            // 
            // btnSellRemove
            // 
            this.btnSellRemove.Location = new System.Drawing.Point(15, 236);
            this.btnSellRemove.Name = "btnSellRemove";
            this.btnSellRemove.Size = new System.Drawing.Size(126, 23);
            this.btnSellRemove.TabIndex = 8;
            this.btnSellRemove.Text = "Ürünü Satıştan Çıkar";
            this.btnSellRemove.UseVisualStyleBackColor = true;
            this.btnSellRemove.Click += new System.EventHandler(this.btnSellRemove_Click);
            // 
            // btnSellAdd
            // 
            this.btnSellAdd.Location = new System.Drawing.Point(159, 236);
            this.btnSellAdd.Name = "btnSellAdd";
            this.btnSellAdd.Size = new System.Drawing.Size(152, 23);
            this.btnSellAdd.TabIndex = 7;
            this.btnSellAdd.Text = "Ürünü Satışa Ekle";
            this.btnSellAdd.UseVisualStyleBackColor = true;
            this.btnSellAdd.Click += new System.EventHandler(this.btnSellAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(150, 143);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(164, 20);
            this.tbxStockAmount.TabIndex = 6;
            this.tbxStockAmount.Text = "1";
            this.tbxStockAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxStockAmount.TextChanged += new System.EventHandler(this.tbxStockAmount_TextChanged);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(150, 104);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(164, 20);
            this.tbxUnitPrice.TabIndex = 5;
            this.tbxUnitPrice.TextChanged += new System.EventHandler(this.tbxUnitPrice_TextChanged);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(150, 65);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(164, 20);
            this.tbxProductName.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(29, 68);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(95, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Satılacak Ürün Adı";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(29, 150);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(104, 13);
            this.lblStockAmount.TabIndex = 2;
            this.lblStockAmount.Text = "Satılacak Ürün Adeti";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(29, 107);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(104, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Satılacak Ürün Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(361, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Satış";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.Location = new System.Drawing.Point(474, 471);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(116, 29);
            this.lblSum.TabIndex = 17;
            this.lblSum.Text = "Toplam :";
            // 
            // dgwCart
            // 
            this.dgwCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCart.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCart.Location = new System.Drawing.Point(366, 194);
            this.dgwCart.Name = "dgwCart";
            this.dgwCart.Size = new System.Drawing.Size(422, 257);
            this.dgwCart.TabIndex = 16;
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(366, 34);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(422, 121);
            this.dgwProducts.TabIndex = 15;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(19, 14);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(324, 121);
            this.gbxSearch.TabIndex = 14;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(115, 38);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(178, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(38, 45);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ürün Adı";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(608, 471);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 29);
            this.lblTotalPrice.TabIndex = 23;
            // 
            // FrmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnSellCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.dgwCart);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxSearch);
            this.Name = "FrmSell";
            this.Text = "Satış Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSell_FormClosing);
            this.Load += new System.EventHandler(this.FrmSell_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnSellCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSellRemove;
        private System.Windows.Forms.Button btnSellAdd;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.DataGridView dgwCart;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}