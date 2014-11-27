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
    public partial class Xoacanbo : Form
    {
        public Xoacanbo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mcb = textmcb.Text;
            string ht = textht.Text;
            string query = "select Macanbo,Hoten from Canbo where Macanbo = '" + mcb + "' and Hoten = '" + ht + "'";
            string connectionString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool r = reader.HasRows;
            conn.Close();
            Log l;
            if(r)
            {
                string query1 = "update Canbo set Trangthailamviec = '0' where Trangthailamviec = '1' ";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                conn.Open();
                int i = cmd1.ExecuteNonQuery();
                if(i>0)
                {
                    MessageBox.Show("OK");
                    this.Hide();
                    l = new Log(DateTime.Now,"Delete",Program.acc," Delete can bo  '" + ht + "'");
                }
                else
                {
                    MessageBox.Show("ERROR");
                    this.Hide();
                    l = new Log(DateTime.Now, "Delete",Program.acc, "Delete faled!");
                }
            }
            else
            {
                MessageBox.Show("khong ton tai can bo hoac ban da nhap sai can bo");
                l = new Log(DateTime.Now, "Delete",Program.acc, "Delete faled!");
                textmcb.Focus();
            }
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost",27017);
            MongoServer server = new MongoServer(settings);
            var databse = server.GetDatabase("MyDB");
            var col = databse.GetCollection("Transaction");
            col.Insert(l);
        }

    }
}
