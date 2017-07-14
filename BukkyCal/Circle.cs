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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void circal_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(textBox3.Text);

            int t = z * z;

            MessageBox.Show(" Given the centre of the circle. the equation of the circle will be (x -" + x + ") ^ 2 + (y - " + y + " ) ^ 2 = " + t   );
        }

        private void Circle_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }
    }
}
