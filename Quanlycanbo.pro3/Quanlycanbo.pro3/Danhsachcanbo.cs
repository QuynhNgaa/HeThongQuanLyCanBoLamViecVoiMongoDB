using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Danhsachcanbo : Form
    {
        public Danhsachcanbo()
        {
            InitializeComponent();
            toolTip1.SetToolTip(dataGridView1, "Nhsdkjasdn");
        }

        private void DScb_Load(object sender, EventArgs e)
        {
            this.vCanboTableAdapter.Fill(this.qLCBDataSet9.VCanbo);
            this.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
