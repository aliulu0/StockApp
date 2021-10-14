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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IProductDal _productDal = new IProductDal();
        private FrmAdd addPage = new FrmAdd();
        private FrmUpdate updatePage = new FrmUpdate();
        private FrmSell sellPage = new FrmSell();
        private FrmHistory historyPage = new FrmHistory();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            addPage.ShowDialog();
        }

        private void btnUpdatePage_Click(object sender, EventArgs e)
        {
            updatePage.ShowDialog();
        }

        private void btnSellPage_Click(object sender, EventArgs e)
        {
            sellPage.ShowDialog();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
                    _productDal.Delete(id);
                    LoadProducts();
                    MessageBox.Show("Ürün Silindi");
                }
                catch (Exception )
                {
                    MessageBox.Show("Silme İşlemi Gerçekleşemedi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ürün seçiniz");
            }
          
            
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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            historyPage.ShowDialog();
        }
    }
}
