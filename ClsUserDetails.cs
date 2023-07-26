using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ShopManagement
{
    internal class ClsUserDetails
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4MS3KTQO;Initial Catalog=ShopManagement;Integrated Security=True");


        public string UserType { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string UserGender { get; set; }

        public string UserState { get; set; }

        public string UserPassWord { get; set; }

        public string UserPhone { get; set; }

        public int TypeId { get; set; }

        public string TypeName { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Size { get; set; }

        public int MRP { get; set; }

        public int RealPrice { get; set; }

        public int SizeID { get; set; }

        public string Status { get; set; }

        public int UserID { get; set; }

        public int Discount { get; set; }

        public int OrderID { get; set; }

        public int IsDeleted { get; set; }

        public ClsUserDetails(int id, int sizeID, string status) // Order button and order confirm
        {
            UserID=id;
            SizeID=sizeID;
            Status=status;
            
        }

        public ClsUserDetails(int TId)
        {
            TypeId= TId;

        }

        public ClsUserDetails()
        {

        }

        public ClsUserDetails(string Type, string Name, string Email, string Gender, string State, string Password, string phone)
        {
            UserType=Type;
            UserName=Name;
            UserEmail=Email;
            UserGender=Gender;
            UserState=State;
            UserPassWord=Password;
            UserPhone=phone;

        }

        //public ClsUserDetails(int discount, int OrderId) //update discount
        //{
        //    Discount=discount;
        //    OrderID=OrderId;
        //}

        public ClsUserDetails(int id, int productId, String size, int mrp, int realprice)

        {
            TypeId=id;
            ProductId=ProductId;
            Size=size;
            MRP = mrp;
            RealPrice=realprice;




        }

        public ClsUserDetails(string TypeName)
        {
            UserName=TypeName;
            
        }

        public ClsUserDetails(int id, string Name)
        {
            TypeId=id;
            TypeName=Name;
        }

        public ClsUserDetails(int Type, int productId)  //All products constructor
        {
            TypeId=Type;
            ProductId=productId;
        }

        public ClsUserDetails(int id, int sizeID, int productId, int Type)   //GetOrderProduct
        {
            UserID=id;
            SizeID=sizeID;
            ProductId=productId;
            TypeId=Type;

        }
       

        public void RegistrationData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RegistrationData");
            cmd.Parameters.AddWithValue("@Type", UserType);
            cmd.Parameters.AddWithValue("@Name", UserName);
            cmd.Parameters.AddWithValue("@Email", UserEmail);
            cmd.Parameters.AddWithValue("@Gender", UserGender);
            cmd.Parameters.AddWithValue("@State", UserState);
            cmd.Parameters.AddWithValue("@Password", UserPassWord);
            cmd.Parameters.AddWithValue("@UserPhone", UserPhone);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void TypeSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TypeSave");
            cmd.Parameters.AddWithValue("@Type", UserType);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable GetType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public void SaveProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            //cmd.Parameters.AddWithValue("@ProductId", ProductId);
            //cmd.Parameters.AddWithValue("@ProductName", ProductName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand=cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public void Booking()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Booking");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@Size", Size);
            cmd.Parameters.AddWithValue("@MRP", MRP);
            cmd.Parameters.AddWithValue("@RealPrice", RealPrice);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public ClsUserDetails(string Type, string Email, string Password)
        {
            UserType= Type;
            UserEmail= Email;
            UserPassWord= Password;
        }

        public SqlDataReader LoginData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LoginData");
            cmd.Parameters.AddWithValue("@Type", UserType);
            cmd.Parameters.AddWithValue("@Email", UserEmail);
            cmd.Parameters.AddWithValue("@Password", UserPassWord);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public DataTable GetSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSize");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public SqlDataReader GetPrice()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPrice");
            cmd.Parameters.AddWithValue("@Size", TypeId);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public void OrderConfirm()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "OrderConfirm");
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@SizeID", SizeID);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetAllProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetOrderProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetOrderProduct");
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@SizeID", SizeID);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@Type", TypeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }


        public DataTable GetSearch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSearch");
            cmd.Parameters.AddWithValue("@Name", UserName);
            cmd.Parameters.AddWithValue("@ProductName", UserName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public void UpdateDiscount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateDiscount");
            cmd.Parameters.AddWithValue("@Discount", ProductId);
            cmd.Parameters.AddWithValue("@OrderId", TypeId);
            cmd.ExecuteNonQuery();
            con.Close();


        }

        public DataTable UnOrderProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnOrderProduct");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable UnOrderCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnOrderCustomer");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void Delete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Delete");
            cmd.Parameters.AddWithValue("@OrderId", TypeId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
