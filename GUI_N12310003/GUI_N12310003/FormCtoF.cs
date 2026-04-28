using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_N12310003
{
    public partial class FormCtoF : Form
    {
        public FormCtoF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double .Parse(textBox1.Text);
            double sum = a*(9/5.0)+32;
            label3.Text = sum.ToString();
        }
    }
}
