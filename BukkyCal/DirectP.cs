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
    public partial class DirectP : Form
    {
        public DirectP()
        {
            InitializeComponent();
        }

        private void dirp_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox1.Text);
            int second = Convert.ToInt32(textBox2.Text);
            int third = Convert.ToInt32(textBox3.Text);

            int fourth = second * third;
            int fifth = fourth / first;

            MessageBox.Show("The Value of Y = " + fifth);
        }

        private void DirectP_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
