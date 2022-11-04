using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CarService
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();  
        }

        Work w = new Work();
        private void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worksheet worksheetForm = new Worksheet();

            //titles
            Label space = new Label();
            //workType.Text = "Work Type";
            Label workType = new Label();
            workType.Text = "Work Type";
            Label materialTitle = new Label();
            materialTitle.Text = "Material Costs";
            Label timeTitle = new Label();
            timeTitle.Text = "Time Required";
            Label totalTitle = new Label();
            totalTitle.Text = "Total";
            totalTitle.Margin = new Padding(26, 1, 9, 0);

            Control[] title = new Control[] { workType, materialTitle, timeTitle, totalTitle};
            worksheetForm.flowLayoutPanel.Controls.AddRange(title);
            worksheetForm.flowLayoutPanel.SetFlowBreak(title[3], true);

            
            worksheetForm.ShowDialog();
            //this.Visible = false;
        }

        //private List<Work> workSheet = new List<Work>();
        WorkParser wp = new WorkParser();

        internal static List<Work> WorkSheet { get; set; } = new List<Work>();

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\txt";
            openFile.Title = "Browse Text files only";
            openFile.Filter = "Text Files only (*.txt) | *.txt";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                WorkSheet = wp.ParseFiles<Work>(openFile.FileName);

                worksheetToolStripMenuItem.Enabled = true;
                paymentToolStripMenuItem.Enabled = true;
            }
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment paymentForm = new Payment();
            paymentForm.ShowDialog();
        }
    }
}
