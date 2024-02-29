using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter
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

        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Error";
            string message = "Length of message is to long to display.";
            if (Input.Text.Length > 140)
                MessageBox.Show(message, title);
            
            else if(Input.Text.Length <= 140)
                DisplayPost.Text = "User 1:  " + Input.Text;
                
        }
    }
}
