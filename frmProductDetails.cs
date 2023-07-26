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
    public partial class frmProductName : Form
    {
        public frmProductName()
        {
            InitializeComponent();
        }

        private void frmProductName_Load(object sender, EventArgs e)
        {
            ClsUserDetails objType = new ClsUserDetails();
            DataTable dt = new DataTable();
            dt=objType.GetType();

            cmbtype.DisplayMember="TypeName";
            cmbtype.ValueMember="TypeId";

            cmbtype.DataSource=dt;


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            ClsUserDetails objUserDetails = new ClsUserDetails(Convert.ToInt32(cmbtype.SelectedValue.ToString()),txtprd.Text);
            objUserDetails.SaveProduct();
            MessageBox.Show("Save Successfully...!");
        }


      }
    
    }

