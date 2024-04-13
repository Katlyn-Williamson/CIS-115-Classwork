using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Zip = { 28734, 28715, 61866, 71101, 34230, 34205, 32789, 90210, 10012, 80517 };
            double[] Charge = { 4.55, 5.25, 5.75, 6.58, 7.16, 8.25, 8.75, 9.89, 9.58, 10.75};
            double ZipCode = Convert.ToDouble(textBox1.Text);
            int ZipEntry = -1;
            
            for (int i = 0; i < Zip.Length; i++)
            {
                if (ZipCode == Zip[i])
                {
                    ZipEntry = i;
                }
            }
            if (ZipEntry != -1)
            {
                label5.Text = "For the Zip Code, " + ZipCode + ", the delivery fee is: " + Charge[ZipEntry].ToString("C2");
            }
            else
            {
                label5.Text = "This is not a valid Zip Code. Please try again, thank you.";
            }
        }
    }
}
