using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTemps
{
    public partial class DailyTemps : Form
    {
        int temp;
        int count = 0;
        int total = 0;
        int average = 0;

        public DailyTemps()
        {
            InitializeComponent();


        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            

            if (count < 7)
            {
                temp = Convert.ToInt32(TempEntry.Text);

                if (temp < -20 || temp > 130)
                {
                    MessageBox.Show("The temperature that you entered does not fall in the acceptable range. Try again.");
                }
                else
                {
                    listBox1.Items.Add(temp);
                    count++;
                    total += temp;
                    TempEntry.Clear();


                }
            }
            else
            {
                temp = Convert.ToInt32(TempEntry.Text);
                
                average = total/7;
                
                btnEnter.Enabled = false;
                TempEntry.Clear();
                lblAverage.Text = "" + average;
                lblTotal.Text = "" + total;
                
                
                
            }
        }
        
    }
}
