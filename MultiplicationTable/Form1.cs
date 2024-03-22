using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m;
            int number;
            int start = 0, end = 10;

            number = Convert.ToInt32(textBox1.Text);

            for(m = start; m <= end; m++)
            {
                listBox1.Items.Add(number + " * " + m + " = " + (number * m));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
    }
}
