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
    public partial class LineSize : Form
    {
        public LineSize()
        {
            InitializeComponent();
        }

        private void lincal_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(textBox1.Text);
            int leno = Convert.ToInt32(textBox2.Text);
           
            double restan = Math.Tan(3.14 / 180);
            double ress = leno / 2;

            double resstwo = restan * ress;

            double ressthree = 2 * resstwo;

            double final = len * ressthree;

            MessageBox.Show("The Linear Size = " +final);
        }

        private void LineSize_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }
    }
}
