using System;
using System.Windows.Forms;

namespace MoveEstimatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double hours;
            hours = txt1 * 150;
            double txt2 = Convert.ToDouble(textBox2.Text);
            double miles;
            miles = txt2 * 2;
            double calculate;
            calculate = hours + miles + 200;
            label5.Text = "For a move taking " + txt1 + " hours, and going " + txt2 + " miles, the estimated cost is $" + calculate;

        }

    }
}
