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
    
    public partial class FrmAdd : Form
    {
        private IProductDal _productDal = new IProductDal();
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Lütfen Alanları giriniz");
                    }
                    else
                    {
                        try
                        {
                            _productDal.Add(new Product
                            {
                                ProductName = tbxProductName.Text,
                                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
                            });
                            MessageBox.Show("Ürün Eklendi");
                            this.Close();
                            item.Text = "";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ürün Ekleme Başarısız");
                        }
                    }
                }
            }
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
