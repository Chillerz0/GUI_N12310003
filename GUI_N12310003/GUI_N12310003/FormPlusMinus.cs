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
    public partial class FormPlusMinus : Form
    {
        public FormPlusMinus()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            String count = Number.Text;
            int sum = Int32.Parse(count)+1;
            Number.Text = sum.ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            String count = Number.Text;
            int sum = Int32.Parse(count)-1;
            Number.Text = sum.ToString();

        }
    }
}
