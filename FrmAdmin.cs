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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllProductInfo Obj=new FrmAllProductInfo();
            Obj.Show();
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderProduct Obj=new FrmOrderProduct();
            Obj.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnOrderProduct objP=new FrmUnOrderProduct();
            objP.Show();
        }

        private void unOrderCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnOrderCustomer Obj=new FrmUnOrderCustomer();
            Obj.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
