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
using System.IO;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Themcanbo : Form
    {
        public Themcanbo()
        {
            InitializeComponent();
            txtmcb.Text = taoMaCanBo();
            txtmcb.Enabled = false;
        }

        public int demSoChuSo(int t)
        {
            int c = 0;
            while (t > 0)
            {
                t = t / 10;
                c++;
            }
            return c;
        }

        public string taoMaCanBo()
        {
            string connectionString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select top 1 Macanbo from Canbo order by Macanbo desc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            string maCu;
            string maMoi = "CB0001";
            if (reader.Read())
            {
                maCu = reader.GetString(0);
                string pre = maCu.Substring(0, 2);
                string number = maCu.Substring(2, maCu.Length - 2);
                int i = int.Parse(number);
                i++;
                int soChuSo = demSoChuSo(i);
                maMoi = pre;
                for (int j = soChuSo; j < 4; j++)
                {
                    maMoi += "0";
                }
                maMoi += i;
            }
            return maMoi;
        }

        private void bth_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_Click(object sender, EventArgs e)
        {
            string mcb = txtmcb.Text;
            string ht = txtht.Text;
            string ns = mktns.Text;
            DateTime ns2 = DateTime.ParseExact(ns, "dd/MM/yyyy", null);
            ns = ns2.ToString("MM/dd/yyyy");
            string dc = txtdc.Text;
            string gt = chknam.Checked ? "1" : "0";
            string sdt = txtsdt.Text;
            string em = mktem.Text;
            string qg = txtqg.Text;
            string dt = txtdt.Text;
            string dv = cbodv.SelectedValue.ToString();
            string nn = txtnn.Text;
            string bc = cbobc.SelectedValue.ToString();
            string tt = chkco.Checked ? "1" : "0";
            Image im = pictureBox1.Image;
            byte[] data = null;
            MemoryStream ms = new MemoryStream();
            im.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            data = ms.ToArray();
            string query = "insert into Canbo values('" + mcb + "',N'" + ht + "','" + ns + "',N'" + dc + "','" + gt + "','" + sdt + "','" + em + "',@image,N'" + qg + "',N'" + dt + "',N'" + dv + "',N'" + nn + "',N'" + bc + "','" + tt + "')";
            string connectionString = "Data Source=ADMINISTRATOR;Initial Catalog=QLCB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("image", data);
            conn.Open();
            Log l;
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Thêm thành công!");
                this.Close();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Thêm cán bộ '" + ht + "'");
            }
            else
            {
                MessageBox.Show("Lỗi!");
                this.Close();
                l = new Log(DateTime.Now, "Thêm", Program.acc, "Lỗi");
            }
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoServer server = new MongoServer(settings);
            var database = server.GetDatabase("MyDB");
            var col = database.GetCollection("Transaction");
            col.Insert(l);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.Multiselect = false;
            string url = ofd.FileName;
            pictureBox1.Image = Image.FromFile(url);
        }

        private void Themcanbo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCBDataSet1.VBangcap' table. You can move, or remove it, as needed.
            this.vBangcapTableAdapter.Fill(this.qLCBDataSet1.VBangcap);
            // TODO: This line of code loads data into the 'qLCBDataSet.VDonvi' table. You can move, or remove it, as needed.
            this.vDonviTableAdapter.Fill(this.qLCBDataSet.VDonvi);

        }

        private void chknam_CheckedChanged(object sender, EventArgs e)
        {
            if(chknam.Checked)
            {
                chknu.Checked = false;
            }
            else
            {
                chknu.Checked = true;
            }
        }

        private void chknu_CheckedChanged(object sender, EventArgs e)
        {
            if(chknu.Checked)
            {
                chknam.Checked = false;
            }
            else
            {
                chknam.Checked = true;
            }
        }

        private void chkco_CheckedChanged(object sender, EventArgs e)
        {
            if(chkco.Checked)
            {
                chkkhong.Checked = false;
            }
            else
            {
                chkkhong.Checked = true;
            }
        }

        private void chkkhong_CheckedChanged(object sender, EventArgs e)
        {
            if(chkkhong.Checked)
            {
                chkco.Checked = false;
            }
            else
            {
                chkco.Checked = true;
            }
        }

        private void txtmcb_Leave(object sender, EventArgs e)
        {
            string i = txtmcb.Text;
            if(i.Length<=0)
            {
                lblmcb.Text = "(Bắt buộc!)";
                txtmcb.Focus();
            }
            else
            {
                lblmcb.Text = "";
            }
        }
        private void mktem_Leave(object sender, EventArgs e)
        {
            string i = mktem.Text;
            if(i.Length<=0)
            {
                lblem.Text = "(Bắt buộc!)";
                mktem.Focus();
            }
            else
            {
                Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase);
                Match match = regex.Match(mktem.Text);
                if (!match.Success)
                {
                    lblem.Text = "(Email sai định dạng!)";
                    mktem.Focus();
                }
                else
                {
                    lblem.Text = "";
                }
            }
        }

        private void txtht_Leave(object sender, EventArgs e)
        {
            string i = txtht.Text;
            if(i.Length<=0)
            {
                lblht.Text = "(Bắt buộc!)";
                txtht.Focus();
            }
            else
            {
                lblht.Text = "";
            }
        }
        private void mktns_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");
            Match match = regex.Match(mktns.Text);
            if (!match.Success)
            {
                lblns.Text = "(Ngày sinh sai định dạng)";
                mktns.Focus();
            }
            else
            {
                lblns.Text = "";
            }
        }

        private void txtdc_Leave(object sender, EventArgs e)
        {
            string i = txtdc.Text;
            if(i.Length<=0)
            {
                lbldc.Text = "(Bắt buộc!)";
                txtdc.Focus();
            }
            else
            {
                lbldc.Text = "";
            }
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            string i = txtsdt.Text;
            if(i.Length<=0)
            {
                lblsdt.Text = "(Bắt buộc!)";
                txtsdt.Focus();
            }
            else
            {
                lblsdt.Text = "";   
            }
        }

        private void txtqg_Leave(object sender, EventArgs e)
        {
            string i = txtqg.Text;
            if(i.Length<=0)
            {
                lblqg.Text = "(Bắt buộc!)";
                txtqg.Focus();
            }
            else
            {
                lblqg.Text = "";
            }
        }

        private void txtdt_Leave(object sender, EventArgs e)
        {
            string i = txtdt.Text;
            if(i.Length<=0)
            {
                lbldt.Text = "(Bắt buộc!)";
                txtdt.Focus();
            }
            else
            {
                lbldt.Text = "";
            }
        }
        private void txtnn_Leave(object sender, EventArgs e)
        {
            string i = txtnn.Text;
            if (i.Length <= 0)
            {
                lblnn.Text = "(Bắt buộc!)";
                txtnn.Focus();
            }
            else
            {
                lblnn.Text = "";
            }
        }

        private void txtsdt_Leave(object sender, EventArgs e)
        {
            string i = txtsdt.Text;
            if(i.Length<=0)
            {
                lblsdt.Text = "(Bắt buộc!)";
                txtsdt.Focus();
            }
            else
            {
                lblsdt.Text = "";
            }
        }

        private void txtmcb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtmcb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtht.Focus();
            }
        }

        private void txtmcb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
