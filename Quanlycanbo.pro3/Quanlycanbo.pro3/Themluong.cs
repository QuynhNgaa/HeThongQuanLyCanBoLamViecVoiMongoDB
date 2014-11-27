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
    public partial class Themluong : Form
    {
        public Themluong()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mcb = textBox1.Text;
            string hsl = textBox2.Text;
            string pccv = textBox3.Text;
            string pcxh = textBox4.Text;
            string mst = textBox5.Text;
            string query = "select Macanbo from Canbo where Macanbo = '" + mcb + "'";
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
                string query1 = "insert into Luong (Macanbo, Hesoluong, Phucapchucvu, Phucapxahoi, Masothue) values('" + mcb + "','" + hsl + "',N'" + pccv + "',N'" + pcxh + "','" + mst + "')";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                conn.Open();
                int i = cmd1.ExecuteNonQuery();
                if(i>0)
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Hide();
                    l = new Log(DateTime.Now, "Thêm", Program.acc, "Thêm hệ số lương '" + hsl + "' cho cán bộ '" + mcb + "'");
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                    textBox1.Focus();
                    l = new Log(DateTime.Now, "Thêm", Program.acc, "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã cán bộ '" + mcb + "' \n Vui lòng kiểm tra lại");
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
    }
}
