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
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = Int32.Parse(labCounter.Text.Replace("秒",""));
            counter+=1; 
            labCounter.Text = counter.ToString()+"秒";  
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1 .Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1 .Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labCounter.Text= "0秒";
        }
    }
}
