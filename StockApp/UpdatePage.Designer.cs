
namespace StockApp
{
    partial class FrmUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.dgwUpdate = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdate)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.tbxStockAmount);
            this.groupBox2.Controls.Add(this.tbxUnitPrice);
            this.groupBox2.Controls.Add(this.tbxProductName);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.lblStockAmount);
            this.groupBox2.Controls.Add(this.lblUnitPrice);
            this.groupBox2.Location = new System.Drawing.Point(60, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 190);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncel Ürün";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Ürünü Günelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(129, 109);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(164, 20);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(129, 70);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(164, 20);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(129, 24);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(164, 20);
            this.tbxProductName.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(39, 32);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(39, 116);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(29, 13);
            this.lblStockAmount.TabIndex = 2;
            this.lblStockAmount.Text = "Stok";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(39, 77);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // dgwUpdate
            // 
            this.dgwUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUpdate.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUpdate.Location = new System.Drawing.Point(60, 103);
            this.dgwUpdate.Name = "dgwUpdate";
            this.dgwUpdate.Size = new System.Drawing.Size(669, 150);
            this.dgwUpdate.TabIndex = 4;
            this.dgwUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUpdate_CellClick);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(60, 12);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(669, 74);
            this.gbxSearch.TabIndex = 3;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(109, 21);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(159, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(39, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(23, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ara";
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwUpdate);
            this.Controls.Add(this.gbxSearch);
            this.Name = "FrmUpdate";
            this.Text = "Güncelleme";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdate)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.DataGridView dgwUpdate;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}