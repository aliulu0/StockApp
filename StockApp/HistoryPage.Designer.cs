
namespace StockApp
{
    partial class FrmHistory
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
            this.dgwHistory = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwHistory
            // 
            this.dgwHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHistory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHistory.Location = new System.Drawing.Point(12, 57);
            this.dgwHistory.Name = "dgwHistory";
            this.dgwHistory.Size = new System.Drawing.Size(646, 280);
            this.dgwHistory.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 367);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgwHistory);
            this.Name = "FrmHistory";
            this.Text = "Geçmiş Satışlar";
            this.Load += new System.EventHandler(this.HistoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHistory;
        private System.Windows.Forms.Button btnRefresh;
    }
}