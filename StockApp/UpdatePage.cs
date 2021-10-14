using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private IProductDal _productDal = new IProductDal();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Lütfen Alanları Doldurunuz");
                    }
                    
                }
            }
            try
            {
                _productDal.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwUpdate.CurrentRow.Cells[0].Value),
                    ProductName = tbxProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmount.Text)

                });
                MessageBox.Show("Ürün Güncellendi");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme İşlemi Tamamlanamadı");
            }

        }

        private void dgwUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxProductName.Text = dgwUpdate.CurrentRow.Cells[1].Value.ToString();
                tbxUnitPrice.Text = dgwUpdate.CurrentRow.Cells[2].Value.ToString();
                tbxStockAmount.Text = dgwUpdate.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception )
            {
                MessageBox.Show("Bir Hata oluştu");
            }
           
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwUpdate.DataSource = _productDal.GetAll();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                LoadProducts();
            }
            else
            {
                dgwUpdate.DataSource = _productDal.GetByProductName(tbxSearch.Text);
            }
        }
    }
}
