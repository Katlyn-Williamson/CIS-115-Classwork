using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineForOverdueBooks
{
    public partial class FineForOverdueBooks : Form
    {
        

        public FineForOverdueBooks()
        {
            InitializeComponent();
            
        }

        private void MethodFirstSeven()
        {
            int BookNum = Convert.ToInt32(BooksCheckedOutEntry.Text);
            int DaysLate = Convert.ToInt32(DaysLateEntry.Text);
            double FirstSeven = .10;
            double FSTotal;

            FSTotal = BookNum * DaysLate * FirstSeven;

            label4.Text = FSTotal.ToString("C");
        }

        private void MethodAfterSeven() 
        {
            int BookNum = Convert.ToInt32(BooksCheckedOutEntry.Text);
            int DaysLate = Convert.ToInt32(DaysLateEntry.Text);
            int DaysAfterSeven;
            double FirstSeven = .10;
            double AfterSeven = .20;
            double FSTotal;
            double ASTotal;
            double Total;
            

            FSTotal = BookNum * 7 * FirstSeven;
            DaysAfterSeven = DaysLate - 7;
            ASTotal = DaysAfterSeven * AfterSeven * BookNum;
            Total = FSTotal + ASTotal;

            label4.Text = Total.ToString("C");


        }

        private void btnFindOutFine_Click(object sender, EventArgs e)
        {
            int BookNum = Convert.ToInt32(BooksCheckedOutEntry.Text);
            int DaysLate = Convert.ToInt32(DaysLateEntry.Text);

            if (DaysLate <= 7)
            {
                MethodFirstSeven();
            }

            if (DaysLate > 7)
            {
                MethodAfterSeven(); 
            }
        }
    }
}
