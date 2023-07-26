using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class FrmAllProductInfo : Form
    {
        public FrmAllProductInfo()
        {
            InitializeComponent();
        }

        private void FrmAllProductInfo_Load(object sender, EventArgs e)
        {
            ClsUserDetails sz = new ClsUserDetails();
            DataTable dt = new DataTable();
            dt=sz.GetAllProduct();
            grdAP.DataSource=dt;
            grdAP.Show();
        }

        private void grdAP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
