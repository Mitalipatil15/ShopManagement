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
    public partial class FrmOrderProduct : Form
    {
        public FrmOrderProduct()
        {
            InitializeComponent();
        }

        private void FrmOrderProduct_Load(object sender, EventArgs e)
        {
            ClsUserDetails sz = new ClsUserDetails();
            DataTable dt = new DataTable();
            dt=sz.GetOrderProduct();
            dataGridView1.DataSource=dt;
            dataGridView1.Show();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ClsUserDetails Obj = new ClsUserDetails(txtsrh.Text);
            DataTable dt = new DataTable();
            dt=Obj.GetSearch();
            dataGridView1.DataSource=dt;
            dataGridView1.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText=="Offer")
            {
                string UserName = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string ProductName = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                int MRP = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                int OrderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                FrmOffer ObjFrmOffer = new FrmOffer(UserName, ProductName, MRP, OrderId);
                ObjFrmOffer.Show();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value !=null)
                {
                    bool a=(bool)dataGridView1.Rows [i].Cells[1].Value;
                    if (a==true)
                    {
                        int OrderID = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        ClsUserDetails frm = new ClsUserDetails(OrderID);
                        frm.Delete();
                        MessageBox.Show("Successfully deleted");
                    }
                    else
                    {
                        int OrderID = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        ClsUserDetails frm = new ClsUserDetails(OrderID);
                        frm.Delete();
                        
                    }
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText=="Offer")
            {
                string UserName = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string ProductName = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                int MRP = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                int OrderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                FrmOffer ObjFrmOffer = new FrmOffer(UserName, ProductName, MRP, OrderId);
                ObjFrmOffer.Show();
            }
        }

        private void btnrfsh_Click(object sender, EventArgs e)
        {
            ClsUserDetails sz = new ClsUserDetails();
            DataTable dt = new DataTable();
            dt=sz.GetOrderProduct();
            dataGridView1.DataSource=dt;
            dataGridView1.Show();
        }
    }
}
