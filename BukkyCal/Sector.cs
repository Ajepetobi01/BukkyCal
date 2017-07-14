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
    public partial class Sector : Form
    {
        public Sector()
        {
            InitializeComponent();
        }

        private void showresult_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            int fin = a * b;
            double final = 0.5 * fin;
            

            
            MessageBox.Show("The Area of the Sector is "+ final
                );
        }

        private void Sector_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }
    }
}
