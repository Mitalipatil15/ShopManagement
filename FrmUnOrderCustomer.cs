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
    public partial class FrmUnOrderCustomer : Form
    {
        public FrmUnOrderCustomer()
        {
            InitializeComponent();
        }

        private void FrmUnOrderCustomer_Load(object sender, EventArgs e)
        {
            ClsUserDetails Obj = new ClsUserDetails();
            DataTable dt = new DataTable();
            dt= Obj.UnOrderCustomer();
            grdUOC.DataSource=dt;
            grdUOC.Show();
        }
    }
}
