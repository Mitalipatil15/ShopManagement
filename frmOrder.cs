using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmOrder : Form
    {
        public int UserID = 0;
        public frmOrder()
        {
            InitializeComponent();
        }

        public frmOrder(string name, string Email, string Phone,int userID)
        {
            InitializeComponent();
            txtName.Text=Name;
            txtEmail.Text=Email;
            txtPhone.Text=Phone;
            UserID=userID;
            
        }


        

        

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbtype.SelectedValue.ToString());
            ClsUserDetails objProduct = new ClsUserDetails(TypeId);
            DataTable dt = new DataTable();
            dt=objProduct.GetProduct();

            cmbproduct.DisplayMember="ProductName";
            cmbproduct.ValueMember="ProductId";

            cmbproduct.DataSource=dt;
        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProductId= Convert.ToInt32(cmbproduct.SelectedValue.ToString());
            ClsUserDetails sz = new ClsUserDetails(ProductId);
            DataTable dt = new DataTable();
            dt=sz.GetSize();
            grdorderdetails.DataSource=dt;
            grdorderdetails.Show();
        }

        private void grdorderdetails_MouseClick(object sender, MouseEventArgs e)
        {
            int SizeID = Convert.ToInt32(grdorderdetails.SelectedRows[0].Cells[0].Value.ToString());
            ClsUserDetails objClsUserDetails=new ClsUserDetails(SizeID);
            SqlDataReader dr;
            dr=objClsUserDetails.GetPrice();

            while(dr.Read())
            {
                txtprice.Text=dr["MRP"].ToString();
            }
            dr.Close();
        }

        private void Add(string Type1, string Product1, string Size1, string Price1, string SizeID)
        {
            {
                ListViewItem objlistView1=new ListViewItem(Type1);
                objlistView1.SubItems.Add(Product1);
                objlistView1.SubItems.Add(Size1);
                objlistView1.SubItems.Add(Price1);
                objlistView1.SubItems.Add(SizeID);
                listView1.Items.Add(objlistView1);
                listView1.Columns[4].Width=0;
            }



        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (grdorderdetails.SelectedRows.Count>0)
            {
                string Size=grdorderdetails.SelectedRows[0].Cells[0].Value.ToString();
                string SizeID=grdorderdetails.SelectedRows [0].Cells[1].Value.ToString();
                string Type=cmbtype.Text;
                string Product=cmbproduct.Text;
                string Price = txtprice.Text;

                Add(Type, Product, Size, Price,SizeID);
            }


        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                sum +=decimal.Parse(item.SubItems[3].Text);

            }
            txttotal.Text=Convert.ToString(sum);

        }

        private void frmOrder_Load_1(object sender, EventArgs e)
        {
            ClsUserDetails objClsUserDetails = new ClsUserDetails();
            DataTable dt = new DataTable();
            dt=objClsUserDetails.GetType();

            cmbtype.DisplayMember="TypeName";
            cmbtype.ValueMember="TypeId";

            cmbtype.DataSource=dt;
            ClsUserDetails objPro = new ClsUserDetails();
            //DataTable dt = new DataTable();
            dt=objPro.GetProduct();

            cmbproduct.DisplayMember="ProductName";
            cmbproduct.ValueMember="ProductId";

            cmbproduct.DataSource=dt;

            listView1.View=View.Details;
            listView1.GridLines=true;
            listView1.FullRowSelect=true;

            listView1.Columns.Add("ProductType", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("ProductName", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("ProductSize", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("ProductPrice", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("ProductSizeID", 100, HorizontalAlignment.Center);


        }
        

       
        private void btnOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                
                string Status = "Confirmed";
                int SizeID = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);

                ClsUserDetails objClsUserDetails=new ClsUserDetails(UserID,SizeID,Status);
                objClsUserDetails.OrderConfirm();
                
            }
                MessageBox.Show("OrderConfirm...!");


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdorderdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
