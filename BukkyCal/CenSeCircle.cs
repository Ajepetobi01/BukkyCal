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
    public partial class CenSeCircle : Form
    {
        public CenSeCircle()
        {
            InitializeComponent();
        }

        private void cent_ca_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            decimal pi = Convert.ToDecimal(textBox2.Text);
            decimal man = 3 * pi;

            decimal mana = 4 * num;

            decimal final = mana / man;

            MessageBox.Show("Result of the Calculation = " +final);

        }

        private void CenSeCircle_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }
    }
}
