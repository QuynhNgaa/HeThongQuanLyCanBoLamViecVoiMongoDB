using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Login
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            timer1.Start();
        }
        public void clock()
        {
            label1.Text = "";
            label1.Text = DateTime.Now.ToString(" dddd dd/MM/yyyy hh:mm:ss tt");
        }
        
        private void f1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Trogiup h = new Trogiup();
                h.Show();
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log l = new Log(DateTime.Now, "Exit", Program.acc ,"Exited");
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            // Create server object to communicate with our server
            MongoServer server = new MongoServer(settings);
            // Get our database instance to reach collections and data
            var database = server.GetDatabase("MyDB");
            var col = database.GetCollection("Access");
            col.Insert(l);
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap l = new Dangnhap();
            l.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            clock();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doimatkhau d = new Doimatkhau();
            d.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trogiup t = new Trogiup();
            t.Show();
        }
        private void danhSáchCánBộToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Danhsachcanbo d = new Danhsachcanbo();
            d.Show();
        }
        private void cánBộToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Xoacanbo x = new Xoacanbo();
            x.Show();
        }
        private void cánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themcanbo t = new Themcanbo();
            t.Show();
        }
        private void canboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suacanbo s = new Suacanbo();
            s.Show();
        }
        private void khenthuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themkhenthuong tk = new Themkhenthuong();
            tk.Show();
        }

        private void khenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themkhenthuongcanbo tkc = new Themkhenthuongcanbo();
            tkc.Show();
        }

        private void kyluatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themkyluat tkl = new Themkyluat();
            tkl.Show();
        }

        private void kỷLuậtCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themkyluatcanbo tklc = new Themkyluatcanbo();
            tklc.Show();
        }

        private void lươngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Themluong tl = new Themluong();
            tl.Show();
        }

        private void donviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themdonvi d = new Themdonvi();
            d.Show();
        }

        private void quáTrìnhCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themquatrinhct tqt = new Themquatrinhct();
            tqt.Show();
        }

        private void bằngCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thembangcap b = new Thembangcap();
            b.Show();
        }

        private void nhậtKýĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            access a = new access();
            a.Show();
        }

        private void nhậtKýTácVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            t.Show();
        }
    }
}
