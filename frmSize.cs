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
    public partial class frmSize : Form
    {
        public frmSize()
        {
            InitializeComponent();
        }

        private void frmSize_Load(object sender, EventArgs e)
        {
            ClsUserDetails objProduct = new ClsUserDetails();
            DataTable dt = new DataTable();
            dt=objProduct.GetProduct();

            cmbprd.DisplayMember="ProductName";
            cmbprd.ValueMember="ProductId";

            cmbprd.DataSource=dt;

            ClsUserDetails objType=new ClsUserDetails();
            dt=objType.GetType();

            cmbtype.DisplayMember="TypeName";
            cmbtype.ValueMember="TypeId";

            cmbtype.DataSource=dt;

        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbtype.SelectedValue.ToString());
            ClsUserDetails objProduct = new ClsUserDetails(TypeId);
            DataTable dt = new DataTable();
            dt=objProduct.GetProduct();

            cmbprd.DisplayMember="ProductName";
            cmbprd.ValueMember="ProductId";

            cmbprd.DataSource=dt;

        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            int ProductId = Convert.ToInt32(cmbprd.SelectedValue.ToString());
            ClsUserDetails objfrmSize = new ClsUserDetails(Convert.ToInt32(cmbtype.SelectedValue.ToString()), Convert.ToInt32(cmbprd.SelectedValue.ToString()), txtsize.Text, Convert.ToInt32(txtmrp.Text), Convert.ToInt32(txtreal.Text));
            objfrmSize.Booking();
            MessageBox.Show("Booking Complete...!");

        }
    }
}
