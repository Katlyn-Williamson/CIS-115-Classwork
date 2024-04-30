using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingEstimate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SqFootage()
        {
            int Length = Convert.ToInt16(LengthEntry.Text);
            int Width = Convert.ToInt16(WidthEntry.Text);

            int SquareFeet = Length * Width;
            int PricePerFoot = 6;
            int TotalCost;

            TotalCost = SquareFeet * PricePerFoot;

            label4.Text = "Price: " + TotalCost.ToString("C");
        }

       

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            SqFootage();

            
        }
    }
}
