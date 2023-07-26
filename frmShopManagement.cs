using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopManagement
{
    public partial class frmShopManagement : Form
    {
        public frmShopManagement()
        {
            InitializeComponent();
        }



        private void frmShopManagement_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration objfrmUserRegistration = new frmUserRegistration();
            objfrmUserRegistration.Show();
            objfrmUserRegistration.MdiParent=this;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductName objfrmProductName = new frmProductName();
            objfrmProductName.Show();
            objfrmProductName.MdiParent= this;
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)

        {
            frmType objfrmType=new frmType();
            objfrmType.Show();
            objfrmType.MdiParent= this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSize objfrmSize = new frmSize();
            objfrmSize.Show();
            objfrmSize.MdiParent=this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.Show();
            objfrmLogin.MdiParent= this;

        }
    }
}
