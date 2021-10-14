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
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            InitializeComponent();
        }

        private IHistoryDal _historyDal = new IHistoryDal();
        private void HistoryPage_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            dgwHistory.DataSource = _historyDal.GetAll();
            dgwHistory.Columns[0].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
