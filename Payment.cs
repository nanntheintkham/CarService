using System;
using System.Linq;
using System.Windows.Forms;

namespace CarService
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }



        //form close event -> will clear the worksheet list we parsed into the file and the workdata file
        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.WorkSheet.Clear();
            Worksheet.WorksheetRegistered.Clear();
            this.Hide();

            MainMenu f = new MainMenu();
            f.Show();


        }

        //loading Payment form
        //will display all the infos indeed for payment
        private void Payment_Load_1(object sender, EventArgs e)
        {
            //finding sum for every data in WorksheetData List for final payment
            double materialTotal = Worksheet.WorksheetRegistered.Sum(x => x.MaterialTotal);
            double serviceTotal = Worksheet.WorksheetRegistered.Sum(x => x.TimeTotal);
            double total = Worksheet.WorksheetRegistered.Sum(x => x.TotalCost);
            int sheetCount = Worksheet.WorksheetRegistered.Sum(x => x.WorksheetCount);
            int count = Worksheet.WorksheetRegistered.Sum(x => x.Count);

            int hours = Worksheet.WorksheetRegistered.Sum(x => x.InvoicedHours);
            int minutes = Worksheet.WorksheetRegistered.Sum(x => x.InvoicedMinutes);
            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes %= 60;
            }

            lblWsheetCount.Text = sheetCount.ToString() + " db";
            lblWorkCount.Text = count.ToString() + " db";
            lblMaterial.Text = materialTotal.ToString() + " Ft";
            lblService.Text = serviceTotal.ToString() + " Ft";
            lblTotal.Text = total.ToString() + " Ft";
            lblInTime.Text = hours.ToString() + " h " + minutes.ToString() + " m";
        }


    }
}
