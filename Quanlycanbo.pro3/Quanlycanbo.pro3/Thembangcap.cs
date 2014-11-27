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
    public partial class Thembangcap : Form
    {
        public Thembangcap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mbc = txtmbc.Text;
            string tbc = txttbc.Text;
            string query = "insert into Bangcap values('" + mbc + "',N'" + tbc + "')";
            string connectionString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            Log l;
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Thêm thành công!");
                this.Close();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Thêm bằng cấp  '" + tbc + "'");
            }
            else
            {
                MessageBox.Show("Lỗi!");
                this.Close();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Lỗi!");
            }
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoServer server = new MongoServer(settings);
            var database = server.GetDatabase("MyDB");
            var col = database.GetCollection("Transaction");
            col.Insert(l);
        }

        private void txtmbc_Leave(object sender, EventArgs e)
        {
            string i = txtmbc.Text;
            if(i.Length<=0)
            {
                lblmbc.Text = "(Bắt buộc!";
                txtmbc.Focus();
            }
            else
            {
                lblmbc.Text = "";
            }
        }

        private void txttbc_Leave(object sender, EventArgs e)
        {
            string i = txttbc.Text;
            if(i.Length<=0)
            {
                lbltbc.Text = "(Bắt buộc!)";
                txttbc.Focus();
            }
            else
            {
                lbltbc.Text = "";
            }
        }
    }
}
