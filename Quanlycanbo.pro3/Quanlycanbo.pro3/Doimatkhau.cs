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
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Doimatkhau : Form
    {
        public Doimatkhau()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cur = textcur.Text;
            string nw = textnw.Text;
            string rnw = textrnw.Text;
            string query = "select Password from Admin where Password = '" + cur + "'";
            string connectionString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool r = reader.HasRows;
            Log l;
            conn.Close();
            if(r)
            {
                string query1 = "update Admin set Password = '" + nw + "' where Password = '" + cur +"'";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                conn.Open();
                int i = cmd1.ExecuteNonQuery();
                if(i>0)
                {
                    MessageBox.Show("Thành công!");
                    this.Hide();
                    l = new Log(DateTime.Now, "Đổi mật khẩu", Program.acc, "Đổi thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                    textcur.Focus();
                    l = new Log(DateTime.Now, "Đổi mật khẩu", Program.acc, "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng!");
                textcur.Focus();
                l = new Log(DateTime.Now, "Đổi mật khẩu", Program.acc, "Lỗi");
            }
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoServer server = new MongoServer(settings);
            var database = server.GetDatabase("MyDB");
            var col = database.GetCollection("Transaction");
            col.Insert(l);
        }
        private void textrnw_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("'" + textnw + "'", RegexOptions.None);
            Match match = regex.Match(textrnw.Text);
            if(!match.Success)
            {
                label5.Text = "(Mật khẩu không khớp!)";
                textrnw.Text = "";
                textrnw.Focus();
            }
            else
            {
                label5.Text = "";
            }
        }

        private void textcur_Leave(object sender, EventArgs e)
        {
            string i = textcur.Text;
            if(i.Length<=0)
            {
                lblmkc.Text = "(Nhập mật khẩu hiện tại!)";
                textcur.Focus();
            }
            else
            {
                lblmkc.Text = "";
            }
        }

        private void textnw_Leave(object sender, EventArgs e)
        {
            string i = textnw.Text;
            if(i.Length<=0)
            {
                lblmkm.Text = "(Nhập mật khẩu mới!)";
                textnw.Focus();
            }
            else
            {
                lblmkm.Text = "";
            }
        }
    }
}
