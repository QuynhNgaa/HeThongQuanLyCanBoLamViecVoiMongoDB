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
using MongoDB.Bson;
using MongoDB.Driver;

namespace Login
{
    public partial class Themkhenthuong : Form
    {
        public Themkhenthuong()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mkt = textBox1.Text;
            string tkt = textBox2.Text;
            string query = "insert into Khenthuong values ('" + mkt + "',N'" + tkt + "')";
            string connectionString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            Log l;
            if(i>0)
            {
                MessageBox.Show("Thêm thành công!");
                this.Hide();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Thêm khen thưởng '" + tkt + "'");
            }
            else
            {
                MessageBox.Show("Lỗi!");
                textBox1.Focus();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Lỗi!");
            }
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoServer server = new MongoServer(settings);
            var database = server.GetDatabase("MyDB");
            var col = database.GetCollection("Transaction ");
            col.Insert(l);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            if(i.Length<=0)
            {
                lblmkt.Text = "(Bắt buộc!)";
                textBox1.Focus();
            }
            else
            {
                lblmkt.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string i = textBox2.Text;
            if (i.Length <= 0)
            {
                lblkt.Text = "(Bắt buộc!)";
                textBox2.Focus();
            }
            else
            {
                lblkt.Text = "";
            }
        }
    }
}
