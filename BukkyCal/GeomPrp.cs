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
    public partial class GeomPrp : Form
    {
        public GeomPrp()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            int numa = Convert.ToInt32(textBox1.Text);
            int numr = Convert.ToInt32(textBox2.Text);
            int numnth = Convert.ToInt32(textBox3.Text);

            double pre = numnth - 1;

            double fin = Math.Pow(numr, pre);

            double reu = numa * fin;

            MessageBox.Show("The " + numnth + "th term is" + " "+ fin);
            
        }

        private void GeomPrp_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }
    }
}
