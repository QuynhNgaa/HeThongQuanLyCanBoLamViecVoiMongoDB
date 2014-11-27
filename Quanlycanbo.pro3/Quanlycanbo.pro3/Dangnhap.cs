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
using MongoDB.Driver;
using MongoDB.Bson;

namespace Login
{
    public partial class Dangnhap : Form
    {

        public Dangnhap()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string acc = textBox1.Text;
            string pwd = textBox2.Text;
            string query = "select * from Admin where Account = '" + acc + "' and Password = '" + pwd + "'";
            string connectionString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool r = reader.HasRows;
            Log l;
            if(r)
            {
                Main m = new Main();
                m.Show();
                m.WindowState = FormWindowState.Maximized;
                this.Hide();
                Program.acc = acc;
                l = new Log(DateTime.Now, "Login",acc ," login successful!");
            }
            else
            {
                MessageBox.Show("Mat khau hoac tai khoan khong dung!");
                textBox1.Focus();
                l = new Log(DateTime.Now, "Login", acc ,"Login failed!");
            }

            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017); 
            // Tạo đối tượng
            MongoServer server = new MongoServer(settings);
            // Nạp dữ liệu vào Mongo
            var database = server.GetDatabase("MyDB"); // Khai báo cơ sở dữ liệu cần nạp vào
            var col = database.GetCollection("Access"); // Khai báo collection cần nạp vào
            col.Insert(l); // Thêm dữ liệu vào Mongo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            if(i.Length<=0)
            {
                lblacc.Text = "(Nhập tài khoản!)";
                textBox1.Focus();
            }
            else
            {
                lblacc.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string i = textBox2.Text;
            if(i.Length<=0)
            {
                lblpwd.Text = "(Nhập mật khẩu!)";
                textBox2.Focus();
            }
            else
            {
                lblpwd.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
