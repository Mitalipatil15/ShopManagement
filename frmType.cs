using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmType : Form
    {

        
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4MS3KTQO;Initial Catalog=UserManagement;Integrated Security=True");

        public frmType()
        {
            InitializeComponent();
        }





        private void frmType_Load(object sender, EventArgs e)
        {


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            ClsUserDetails objUserDetails = new ClsUserDetails();
            objUserDetails.TypeSave();
            MessageBox.Show("Save successfully...!");

        }
    }
}
