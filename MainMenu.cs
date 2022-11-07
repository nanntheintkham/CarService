using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarService
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worksheet worksheetForm = new Worksheet();

            //titles for worksheet form
            Label space = new Label();
            Label workType = new Label();
            workType.Text = "Service Type";
            Label materialTitle = new Label();
            materialTitle.Text = "Material Costs";
            Label timeTitle = new Label();
            timeTitle.Text = "Time Required";
            Label totalTitle = new Label();
            totalTitle.Text = "Total";
            totalTitle.Margin = new Padding(26, 1, 9, 0);

            Control[] title = new Control[] { workType, materialTitle, timeTitle, totalTitle };
            worksheetForm.flowLayoutPanel.Controls.AddRange(title);
            worksheetForm.flowLayoutPanel.SetFlowBreak(title[3], true);

            //Show the worksheet form and hide the current menu
            this.Hide();
            worksheetForm.ShowDialog();
            
        }

        //Call workparser class to parse the file
        WorkParser wp = new WorkParser();

        //Create a work list to save the values from the parsed file
        internal static List<Work> WorkSheet { get; set; } = new List<Work>();

        //Loading file and putting it in the list
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\txt";
            openFile.Title = "Browse Text files only";
            openFile.Filter = "Text Files only (*.txt) | *.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                WorkSheet = wp.ParseFiles<Work>(openFile.FileName);

                worksheetToolStripMenuItem.Enabled = true;
                
            }
        }

        //show the registered worksheet and total cost
        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Payment paymentForm = new Payment();
            paymentForm.ShowDialog();
         }

        //show today date and neptun code
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var todayDate = DateTime.Now.ToString("yyyy.MM.dd");
            MessageBox.Show($"{todayDate}\nA4A6YY", "About");
        }

        //exit the program
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Attention",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                System.Windows.Forms.Application.Exit();
            }
            else
            {
                return;
            }   
            
        }

        //disable the menu functions while the list is empty
        private void MainMenu_Load(object sender, EventArgs e)
        {
           if(WorkSheet.Count == 0)
            {
                worksheetToolStripMenuItem.Enabled = false;
                paymentToolStripMenuItem.Enabled = false;
            }
           
        }
    }
}
