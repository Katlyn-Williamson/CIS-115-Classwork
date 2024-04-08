using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoreList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Score1 = Convert.ToInt32(textBox1.Text);
            int Score2 = Convert.ToInt32(textBox2.Text);
            int Score3 = Convert.ToInt32(textBox3.Text);
            int Score4 = Convert.ToInt32(textBox4.Text);
            int Score5 = Convert.ToInt32(textBox5.Text);
            int Score6 = Convert.ToInt32(textBox6.Text);
            int Score7 = Convert.ToInt32(textBox7.Text);
            int Score8 = Convert.ToInt32(textBox8.Text);
            int[] Grades = new int[] {Score1, Score2, Score3, Score4, Score5, Score6, Score7, Score8};
            int[] DifferenceArray = new int[8];
            int Sum = Grades.Sum();
            int Average = Sum / 8;
            int Difference;

            for (int i = 0; i < Grades.Length; i++)
            {

                if (Grades[i] > Average)
                {
                    Difference = Grades[i] - Average;
                }

                else if (Grades[i] < Average)
                {
                    Difference = Average - Grades[i];
                }

                else 
                { 
                    Difference = 0; 
                }

                DifferenceArray[i] = Difference;

                lblAvg.Text = Average.ToString();

                lblScore1.Text = "This score is " + DifferenceArray[0] + " points away from the average.";
                lblScore2.Text = "This score is " + DifferenceArray[1] + " points away from the average.";
                lblScore3.Text = "This score is " + DifferenceArray[2] + " points away from the average.";
                lblScore4.Text = "This score is " + DifferenceArray[3] + " points away from the average.";
                lblScore5.Text = "This score is " + DifferenceArray[4] + " points away from the average.";
                lblScore6.Text = "This score is " + DifferenceArray[5] + " points away from the average.";
                lblScore7.Text = "This score is " + DifferenceArray[6] + " points away from the average.";
                lblScore8.Text = "This score is " + DifferenceArray[7] + " points away from the average.";
            }
        }
    }
}
