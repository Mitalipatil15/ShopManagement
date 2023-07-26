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
using System.Text.RegularExpressions;

namespace ShopManagement
{
    public partial class frmLogin : Form
    {
        string UserName;
        string UserEmail;
        string UserPassword;
        int UserID;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string UserType= cmbtype.Text;
            string Email= txtEmail.Text;
            string Password= txtPassword.Text;
            
            ClsUserDetails sc = new ClsUserDetails(UserType,Email,Password);
            SqlDataReader dr;
            dr = sc.LoginData();
            while (dr.Read())

            {
                UserName=dr["UserName"].ToString();
                UserEmail=dr["UserEmail"].ToString();
                UserPassword=dr["UserPassword"].ToString();
                UserID = Convert.ToInt32(dr["UserID"].ToString());

                if (dr.HasRows == true)
                { 
                    if (UserType == "Customer")
                    {

                        frmOrder objfrmOrder = new frmOrder(UserName, UserEmail, UserPassword, UserID);

                        objfrmOrder.Show();
                        MessageBox.Show("Login successfully...!");
                    }

                    if (UserType == "Admin")
                    {
                        FrmAdmin objAdmin = new FrmAdmin();
                        objAdmin.Show();
                        MessageBox.Show("Login successfully...!");
                    }
                }
            }

            
        }

        //private void txtEmail_TextChanged(object sender, EventArgs e)
        //{
        //    string pattern = "^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{ 1,3}\.[0-9]{ 1,3}\.[0-9]{ 1,3}\.[0-9]{ 1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{ 2,}))$";
        //    if (Regex.IsMatch(txtEmail.Text, pattern))
        //    {
        //        errorProvider1.Clear();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(this.txtEmail, "Plzzz provide valid Email Address ");
        //        return;
        //    }

        //}

        private void frmLogin_Leave(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$" ;
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

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
