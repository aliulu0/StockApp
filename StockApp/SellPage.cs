using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    public partial class FrmSell : Form
    {
        private IProductDal _productDal = new IProductDal();
        private ISellProductDal _sellProductDal = new ISellProductDal();
        private IHistoryDal _historyDal = new IHistoryDal();
        public FrmSell()
        {
            InitializeComponent();
           
        }
        

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                LoadProducts();
            }
            else
            {
                dgwProducts.DataSource = _productDal.GetByProductName(tbxSearch.Text);
            }
        }

        private void FrmSell_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCart();
        }

      private void TotalPriceCal()
        {
            try
            {
                lblTotalPrice.Text = _sellProductDal.SellCal(lblTotalPrice.Text);

            }
            catch (Exception )
            {
                
            }
        }

        private void LoadCart()
        {
            dgwCart.DataSource = _sellProductDal.GetAll();
            lblDate.Text = DateTime.Now.ToString();
            dgwCart.Columns[0].Visible = false;
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
            
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;
            tbxId.Text = row.Cells[0].Value.ToString();
            tbxProductName.Text = row.Cells[1].Value.ToString();
            tbxUnitPrice.Text = row.Cells[2].Value.ToString();
        }

       
        
        private void btnSellAdd_Click(object sender, EventArgs e)
        {
            bool idControl = _sellProductDal.IdContorol(tbxId.Text);

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (String.IsNullOrEmpty(item.Text))
                    {
                        
                    }
                
                }
            }

            if (idControl == true)
            {
                try
                {
                    _sellProductDal.Add(new SellProduct
                    {
                        ProductId = Convert.ToInt32(tbxId.Text),
                        ProductName = tbxProductName.Text,
                        UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                        StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                        SumPrice = Convert.ToDecimal(tbxTotalPrice.Text),
                        Date = lblDate.Text
                    });
                    LoadCart();
                    TextClear();
                    TotalPriceCal();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                
                _sellProductDal.StockUpdate(tbxId.Text,tbxStockAmount.Text);
                LoadCart();
                TextClear();
                TotalPriceCal();
            }

        }

        private void TextClear()
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != tbxStockAmount)
                    {
                        item.Text = "";
                        tbxStockAmount.Text = "1";
                    }
                }
            }
        }

        private void btnSellRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwCart.CurrentRow.Cells[0].Value);
            _sellProductDal.Delete(id);
            LoadCart();
            TotalPriceCal();
        }

        private void tbxUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxStockAmount.Text) || String.IsNullOrEmpty(tbxUnitPrice.Text))
            {
                
            }
            else
            {
                try
                {
                    tbxTotalPrice.Text = (Convert.ToDecimal(tbxUnitPrice.Text) * Convert.ToDecimal(tbxStockAmount.Text))
                        .ToString();
                }
                catch (Exception )
                {
                    
                }
                
            }
        }

        private void tbxStockAmount_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxStockAmount.Text) || String.IsNullOrEmpty(tbxUnitPrice.Text))
            {

            }
            else
            {
                try
                {
                    tbxTotalPrice.Text = (Convert.ToDecimal(tbxUnitPrice.Text) * Convert.ToDecimal(tbxStockAmount.Text))
                        .ToString();
                }
                catch (Exception)
                {

                }

            }
        }

        private void tbxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSellCancel_Click(object sender, EventArgs e)
        {
            _sellProductDal.SellCancel();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı");
            TextClear();
            LoadCart();
            TotalPriceCal();
            

        }
        

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgwCart.Rows.Count - 1; i++)
                {
                    _historyDal.Sell(new History
                    {
                        ProductId = Convert.ToInt32(dgwCart.Rows[i].Cells[1].Value),
                        ProductName = dgwCart.Rows[i].Cells[2].Value.ToString(),
                        StockAmount = Convert.ToInt32(dgwCart.Rows[i].Cells[4].Value),
                        SumPrice = Convert.ToDecimal(dgwCart.Rows[i].Cells[5].Value),
                        Date = dgwCart.Rows[i].Cells[6].Value.ToString()
                    });
                    _sellProductDal.SellUpdate((dgwCart.Rows[i].Cells[1].Value).ToString(), (dgwCart.Rows[i].Cells[4].Value).ToString());
                }

                _sellProductDal.SellCancel();
                TextClear();
                LoadProducts();
                LoadCart();
                TotalPriceCal();
            }
            catch (Exception )
            {
                MessageBox.Show("İşlem Gerçekleştirilemedi");
            }
          


        }

        private void FrmSell_FormClosing(object sender, FormClosingEventArgs e)
        {
            _sellProductDal.SellCancel();
        }
    }
}
