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
    public partial class Themkyluat : Form
    {
        public Themkyluat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mkl = textBox1.Text;
            string tkl = textBox2.Text;
            string query = "insert into Kyluat values ('" + mkl + "',N'" + tkl + "')";
            string connectString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            Log l;
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Thành Công!");
                this.Hide();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Thêm kỷ luật   '" + tkl + "'");
            }
            else
            {
                MessageBox.Show("Lỗi!");
                textBox1.Focus();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Lỗi");
            }
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoServer server = new MongoServer(settings);
            var database = server.GetDatabase("MyDB");
            var col = database.GetCollection("Transaction");
            col.Insert(l);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            if (i.Length <= 0)
            {
                lblmkl.Text = "(Bắt buộc!)";
                textBox1.Focus();
            }
            else
            {
                lblmkl.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string i = textBox2.Text;
            if (i.Length <= 0)
            {
                lblkl.Text = "(Bắt buộc!)";
                textBox2.Focus();
            }
            else
            {
                lblkl.Text = "";
            }
        }
    }
}
