using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

         
        

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            this.Visible = false;
        }

        private void Payment_Load_1(object sender, EventArgs e)
        {
            double materialTotal = MainMenu.WorkSheet.Sum(x => x.MaterialCost);
            double serviceTotal = MainMenu.WorkSheet.Sum(x => x.TimeCost);
            double total = MainMenu.WorkSheet.Sum(x => x.TotalCost);
            double count = MainMenu.WorkSheet.Sum(x => x.Count);

            txtCount.Text = count.ToString();
            txtMaterial.Text = materialTotal.ToString();
            txtService.Text = serviceTotal.ToString();
            txtTotal.Text = total.ToString();
        }
    }
}
