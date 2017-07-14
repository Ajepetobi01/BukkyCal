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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //This Buttons below launches the equation forms as noted on the buttons.
        private void button1_Click(object sender, EventArgs e)
        {
            LinInter frm = new LinInter();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LineSize frm = new LineSize();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeomPrp frm = new GeomPrp();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Euler frm = new Euler();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PercentageChange frm = new PercentageChange();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ArithPro frm = new ArithPro();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sector frm = new Sector();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DirectP frm = new DirectP();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Circle frm = new Circle();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CenSeCircle frm = new CenSeCircle();
            frm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            
        }
    }
}
