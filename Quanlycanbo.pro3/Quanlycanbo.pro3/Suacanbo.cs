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
    public partial class Suacanbo : Form
    {
        public Suacanbo()
        {
            InitializeComponent();
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(f1);
        }

        private void f1(object sender, KeyEventArgs e)
        {
        }


        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
