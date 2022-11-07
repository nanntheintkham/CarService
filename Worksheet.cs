using CarService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class Worksheet : Form
    {
        public Worksheet()
        {
            InitializeComponent();

                       
        }

        
        //declaring checkbox list and label list
        List<CheckBox> chkBox = new List<CheckBox>();
        List<Label> totalCost = new List<Label>();
        //static list for worksheetdata to store and use them from payment form
        internal static List<WorksheetData> WorksheetRegistered = new List<WorksheetData>();

        
        //displaying the data as there is in the file in form load
        private void Worksheet_Load(object sender, EventArgs e)
        {
                        
            foreach (Work workData in MainMenu.WorkSheet)
            {
                
                Label workType = new Label();
                workType.Text = workData.WorkType;
                Label materialCost = new Label();
                materialCost.Text = Convert.ToString(workData.MaterialCost);
                Label time = new Label();
                time.Text = Convert.ToString(workData.Hours) + "h " + Convert.ToString(workData.Minutes) + "m";
                CheckBox select = new CheckBox();
                select.AutoSize = true;
                Label totalLbl = new Label();
                totalLbl.Text = "";

                flowLayoutPanel.Controls.Add(workType);
                flowLayoutPanel.Controls.Add(materialCost);
                flowLayoutPanel.Controls.Add(time);
                flowLayoutPanel.Controls.Add(select);
                flowLayoutPanel.Controls.Add(totalLbl);

                totalCost.Add(totalLbl);
                chkBox.Add(select);

                flowLayoutPanel.SetFlowBreak(totalLbl, true);

                //checkbox event for checking if the user check the checkbox or not
                select.Click += new EventHandler(ShowCheckedTotal);
                
            }
        }

        //showing total cost for the checked ones
        private void ShowCheckedTotal(object sender, System.EventArgs e)
        {
            
            double materialTotal = 0, timeTotal = 0;
            for (int i = 0; i < chkBox.Count; i++)
            {

                double total = 0, material = 0, time = 0;
                
                if (chkBox[i].Checked && chkBox[i].Enabled)
                {
                    material = MainMenu.WorkSheet[i].MaterialCost;
                    

                    //service time less than 30 min will count as 30
                    if (MainMenu.WorkSheet[i].Minutes <= 30 && MainMenu.WorkSheet[i].Hours == 0)
                    {
                        time = 7500;
                        
                    }
                    else
                    {
                        
                        time = (MainMenu.WorkSheet[i].Minutes * 250) + MainMenu.WorkSheet[i].Hours * 15000; ;
                    }
                    total = material + time;
                    totalCost[i].Text = Convert.ToString(total);

                    
                    materialTotal += material;
                    timeTotal += time;
                }
                else
                {
                    totalCost[i].Text = "";
                    
                }
                txtMaterial.Text = Convert.ToString(materialTotal);
                txtTime.Text = Convert.ToString(timeTotal);                
            }  
            
           
        }

        
        private void Worksheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Checking whether the user closed without registering or not
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Do you want to close this without registering worksheet?", "Worksheet Registeration",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Hide();

                    MainMenu f = new MainMenu();
                    f.Show();

                    //if there is no data in worksheetRegistered list,
                    //the menu for payment will be disabled
                    if (WorksheetRegistered.Sum(x => x.WorksheetCount) == 0)
                        f.paymentToolStripMenuItem.Enabled = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        //registering the worksheet data to the list
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(CheckBox chk in chkBox)
            {
                if (chk.Checked)
                {
                    count++;
                }

            }

            //adding data to Worksheet list
            WorksheetData paymentData = new WorksheetData
            {
                MaterialTotal = Convert.ToDouble(txtMaterial.Text),
                TimeTotal = Convert.ToDouble(txtTime.Text),
                TotalCost = Convert.ToDouble(txtMaterial.Text) + Convert.ToDouble(txtTime.Text),
                InvoicedHours = (int)(Convert.ToDouble(txtTime.Text) / 15000),
                InvoicedMinutes = (int)((Convert.ToDouble(txtTime.Text) % 15000) / 250),
                Count = count,
                WorksheetCount = 1
            };

            WorksheetRegistered.Add(paymentData);
            MessageBox.Show($"Paysheet registered!");

            //hide the current form and show the mainmenu
            //the tool strip menu for payment will be enabled on registering
            this.Hide();
            MainMenu m = new MainMenu();
            m.Show();
            m.paymentToolStripMenuItem.Enabled = true;
        }
    }
}
