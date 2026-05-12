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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[]numbers = new int[10];
                numbers[0]=1;
                numbers[1]=2;
                MessageBox.Show(numbers[10].ToString());

                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                int sum = a + b;
                label3.Text=sum.ToString();
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"你輸入的有問題，但我不知道是哪裡錯了"); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
