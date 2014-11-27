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
    public partial class Themquatrinhct : Form
    {
        public Themquatrinhct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mqt = textBox1.Text;
            string cv = textBox2.Text;
            string mdv = textBox3.Text;
            string mcb = textBox4.Text;
            string bd = textBox5.Text;
            string kt = textBox6.Text;
            string query = "select Canbo.Macanbo,Donvi.Madonvi from Canbo,Donvi where Canbo.Macanbo='" + mcb + "' and Donvi.Madonvi='" + mdv + "'";
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
                string query1 = "insert into Quatrinhcongtac values('" + mqt + "',N'" + cv + "','" + mdv + "','" + mcb + "',N'" + bd + "',N'" + kt + "')";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Hide();
                    l = new Log(DateTime.Now, "Thêm", Program.acc, "Thêm công việc '" + cv + "'");
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
                MessageBox.Show("Không tồn tại mã cán bộ '" + mcb + "' hoặc không tồn tại mã đơn vị '" + mdv + "' \n Vui lòng kiểm tra lại!");
                textBox3.Focus();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Lỗi");
            }
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost",27017);
            MongoServer server = new MongoServer(settings);
            var database = server.GetDatabase("MyDB");
            var col = database.GetCollection("Transaction");
            col.Insert(l);
        }

        private void Themquatrinhct_Load(object sender, EventArgs e)
        {

        }
    }
}
