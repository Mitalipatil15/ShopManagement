using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ShopManagement
{
    public partial class frmUserRegistration : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4MS3KTQO;Initial Catalog=UserManagement;Integrated Security=True");
        public frmUserRegistration()
        {
            InitializeComponent();
        }
        public string Gender;
        private void frmUserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ClsUserDetails objUserDetails = new ClsUserDetails(cmbtype.Text,txtName.Text,txtEmail.Text,Gender,cmbst.Text,txtpass.Text,txtphone.Text);
            objUserDetails.RegistrationData();
            MessageBox.Show("Registed...!");
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender="Male";
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender="Female";
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            cmbtype.SelectedItem= null;
            txtName.Text=null;
            txtEmail.Clear();
            rdbFemale.Checked=false;
            rdbMale.Checked=false;
            cmbst.SelectedItem=null;
            txtpass.Clear();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtEmail, "Plzzz provide valid Email Address ");
                return;
            }
        }
    }
}
