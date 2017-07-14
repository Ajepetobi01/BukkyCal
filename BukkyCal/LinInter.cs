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
    public partial class LinInter : Form
    {
        public LinInter()
        {
            InitializeComponent();
        }

        private void liint_Click(object sender, EventArgs e)
        {
            int xone = Convert.ToInt32(textBox1.Text);
            int yone = Convert.ToInt32(textBox2.Text);
            int xtwo = Convert.ToInt32(textBox3.Text);
            int ytwo = Convert.ToInt32(textBox4.Text);
            int x = Convert.ToInt32(textBox5.Text);

            double xxone = x - xone;
            double ytwoyone = ytwo - yone;
            double xtwoxone = xtwo - xone;

            double aii = xxone * ytwoyone;
            double aiii = aii / xtwoxone;
            double ai = aiii + yone;
            MessageBox.Show("The Interpolated Value Y = " + ai);
        }

        private void LinInter_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }
    }
}
