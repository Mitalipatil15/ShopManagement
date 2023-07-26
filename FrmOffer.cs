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
    public partial class FrmOffer : Form
    {
        int OrderId;
        public FrmOffer()
        {
            InitializeComponent();
        }
        public FrmOffer( string Name,string ProductName,int Price,int orderId)
        {
            InitializeComponent();
            lblNM.Text=Name;
            lblName.Text = ProductName;
            lblprice.Text=Price.ToString();
            OrderId=orderId;
            
        }
        private void FrmOffer_Load(object sender, EventArgs e)
        {

        }

        private void btncp_Click(object sender, EventArgs e)
        {
            int Discount = ((Convert.ToInt32(lblprice.Text)* Convert.ToInt32(txtDP.Text)/100));
            txtNP.Text = (Convert.ToInt32(lblprice.Text)-Discount).ToString();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            
            ClsUserDetails objp = new ClsUserDetails(OrderId,Convert.ToInt32(txtDP.Text));
            objp.UpdateDiscount();
            MessageBox.Show("Updated");
        }

        private void txtDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gbxoffer_Enter(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
