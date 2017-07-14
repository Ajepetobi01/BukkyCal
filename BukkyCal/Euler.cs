using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukkyCal
{
    public partial class Euler : Form
    {
        public Euler()
        {
            InitializeComponent();
        }

        private void eulercal_Click(object sender, EventArgs e)
        {
            int yo = Convert.ToInt32(textBox1.Text);
            int h = Convert.ToInt32(textBox2.Text);
            // int n = Convert.ToInt32(textBox3.Text);


            int d = h * yo;
            int ynext = yo + d;

            MessageBox.Show(" test" + ynext);
        }

        private void Euler_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }
    }
}
