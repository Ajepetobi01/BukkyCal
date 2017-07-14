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
    public partial class PercentageChange : Form
    {
        public PercentageChange()
        {
            InitializeComponent();
        }

        private void pccal_Click(object sender, EventArgs e)
        {
            //Take input from textboxex and convert to int
            int numa = Convert.ToInt32(textBox1.Text);
            int numb = Convert.ToInt32(textBox2.Text);

            //subtract the first number from the second number
            //using the formula numb- numa / numa * 100
            float res = numb - numa;

            float resa = res / numa;
            float fina = resa * 100;
            if (numa < numb)
            {

                MessageBox.Show("The Percentage Increase = " + fina +"%");
            }
            else {
                MessageBox.Show("The Percentage Decrease = " + fina+"%");
            }
        }

        private void PercentageChange_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aquamarine;
        }
    }
}
