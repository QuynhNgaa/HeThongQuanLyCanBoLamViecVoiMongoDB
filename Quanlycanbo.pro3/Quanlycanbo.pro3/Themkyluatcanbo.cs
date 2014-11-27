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
    public partial class Themkyluatcanbo : Form
    {
        public Themkyluatcanbo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mcb = cboklcb.Text;
            string mkl = cbokl.Text;
            string nkl = textBox3.Text;
            string ld = textBox4.Text;
            string ht = textBox5.Text;
            string query = "insert into Kyluatcanbo values('" + mcb + "','" + mkl + "','" + nkl + "','" + ld + "','" + ht + "')";
            string connectionString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            Log l;
            if(i>0)
            {
                MessageBox.Show("Thêm thành công!");
                this.Close();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Thêm kỷ luật  '" + mkl + "'  cán bộ  '" + mcb + "'");
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
            var coll = database.GetCollection("Transaction");
            coll.Insert(l);
        }

        private void Themkyluatcanbo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCBDataSet3.Vkyluat' table. You can move, or remove it, as needed.
            this.vkyluatTableAdapter.Fill(this.qLCBDataSet3.Vkyluat);

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string i = textBox4.Text;
            if (i.Length <= 0)
            {
                lblld.Text = "(Bắt buộc!)";
                textBox4.Focus();
            }
            else
            {
                lblld.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            string i = textBox5.Text;
            if (i.Length <= 0)
            {
                lblht.Text = "(Bắt buộc!)";
                textBox5.Focus();
            }
            else
            {
                lblht.Text = "";
            }
        }
    }
}
