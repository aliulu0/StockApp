
namespace StockApp
{
    partial class Form1
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnSellPage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdatePage = new System.Windows.Forms.Button();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(434, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(746, 378);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(131, 23);
            this.btnHistory.TabIndex = 14;
            this.btnHistory.Text = "Geçmiş";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnSellPage
            // 
            this.btnSellPage.Location = new System.Drawing.Point(562, 378);
            this.btnSellPage.Name = "btnSellPage";
            this.btnSellPage.Size = new System.Drawing.Size(140, 23);
            this.btnSellPage.TabIndex = 13;
            this.btnSellPage.Text = "Satış İşlemleri";
            this.btnSellPage.UseVisualStyleBackColor = true;
            this.btnSellPage.Click += new System.EventHandler(this.btnSellPage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdatePage
            // 
            this.btnUpdatePage.Location = new System.Drawing.Point(209, 378);
            this.btnUpdatePage.Name = "btnUpdatePage";
            this.btnUpdatePage.Size = new System.Drawing.Size(150, 23);
            this.btnUpdatePage.TabIndex = 11;
            this.btnUpdatePage.Text = "Ürün Güncelleme İşlemleri";
            this.btnUpdatePage.UseVisualStyleBackColor = true;
            this.btnUpdatePage.Click += new System.EventHandler(this.btnUpdatePage_Click);
            // 
            // btnAddPage
            // 
            this.btnAddPage.Location = new System.Drawing.Point(20, 379);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(151, 23);
            this.btnAddPage.TabIndex = 10;
            this.btnAddPage.Text = "Ürün Ekleme İşlemleri";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(20, 159);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(857, 154);
            this.dgwProducts.TabIndex = 9;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(20, 53);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(857, 100);
            this.gbxSearch.TabIndex = 8;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(116, 36);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(178, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(39, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnSellPage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdatePage);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSellPage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdatePage;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

