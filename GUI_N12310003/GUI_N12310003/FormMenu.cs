using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_N12310003
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if(!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv","時間,飲料,配菜,點心,沙拉\n",Encoding.UTF8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currenDateTime = DateTime.Now;
            string formattedDateTime = currenDateTime.ToString("yyyy/MM/dd HH:mm:ss");

            string drink = "", sidedish = "", dessert = "", salad = "";





            foreach(Control c in panel1.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if(temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        drink+=" "+temp.Text;
                    }
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        sidedish+=" "+temp.Text;
                    }
                }
            }

            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        dessert+=" "+temp.Text;
                    }
                }
            }

            foreach (Control c in panel4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        salad+=" "+temp.Text;
                    }
                }
            }

            File.AppendAllText("OrderData.csv", formattedDateTime+","+drink+","+sidedish+","+dessert+","+salad+"\n");
            MessageBox.Show("點餐完成!製作中請稍等");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
