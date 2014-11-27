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
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Themkhenthuongcanbo : Form
    {
        public Themkhenthuongcanbo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mcb = cboktcb.Text;
            string mkt = cbkt.Text;
            string nk = maskedTextBox1.Text;
            DateTime nk2 = DateTime.ParseExact(nk, "dd/MM/yyyy", null);
            nk = nk2.ToString();
            string ld = textBox4.Text;
            string ht = textBox5.Text;
            string query = "insert into Khenthuongcanbo values('" + mcb + "','" + mkt + "','" + nk + "','" + ld + "','" + ht + "')";
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
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Thêm khen thưởng '" + mkt + "' cho cán bộ '" + mcb + "'");
            }
            else
            {
                MessageBox.Show("Lỗi!");
                cboktcb.Focus();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Lỗi");
            }
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoServer server = new MongoServer(settings);
            var database = server.GetDatabase("MyDB");
            var coll = database.GetCollection("Transaction");
            coll.Insert(l);
        }

        private void Themkhenthuongcanbo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCBDataSet2.VKhenthuong' table. You can move, or remove it, as needed.
            this.vKhenthuongTableAdapter.Fill(this.qLCBDataSet2.VKhenthuong);
            // TODO: This line of code loads data into the 'qLCBDataSet9.VCanbo' table. You can move, or remove it, as needed.
            this.vCanboTableAdapter.Fill(this.qLCBDataSet9.VCanbo);

        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("dd/MM/yyyy");
            Match match = regex.Match(maskedTextBox1.Text);
            if (!match.Success)
            {
                lblnk.Text = "(Ngày khen sai định dạng!)";
                maskedTextBox1.Focus();
            }
            else
            {
                lblnk.Text = "";
            }
        }
    }
}
