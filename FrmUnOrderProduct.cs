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
    public partial class FrmUnOrderProduct : Form
    {
        public FrmUnOrderProduct()
        {
            InitializeComponent();
        }

        private void FrmUnOrderProduct_Load(object sender, EventArgs e)
        {
            ClsUserDetails Obj=new ClsUserDetails();
            DataTable dt=new DataTable();
            dt= Obj.UnOrderProduct();
            grdUOP.DataSource=dt;
            grdUOP.Show();

        }
    }
}
