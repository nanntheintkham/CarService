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
    public partial class Form1 : Form
    {
        public Form1()
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
            
            Control[] title = new Control[] { workType, timeTitle, materialTitle,space, totalTitle};
            worksheetForm.flowLayoutPanel.Controls.AddRange(title);
            worksheetForm.flowLayoutPanel.SetFlowBreak(title[4], true);

            //foreach (Work workData in WorkSheet)
            //{
                //string[] dataArray = line.Split(';');

                
                //foreach (string data in workData)
                //{
                   // Label newLabel = new Label();
                    //newLabel.Name = "lbl" + data;
                   // newLabel.Text = data;
                   // worksheetForm.flowLayoutPanel.Controls.Add(newLabel);
                    
                //}

                                
                /*double time = Convert.ToDouble(dataArray[1]);
                double mateiral = Convert.ToDouble(dataArray[2]);
                Work.MaterialCost.Add(mateiral);
                Work.TimeCost.Add(time);

                Label total = new Label();
                Work.TotalCost.Add(mateiral + (time * 300));

                
                worksheetForm.flowLayoutPanel.Controls.Add(total);
                worksheetForm.flowLayoutPanel.SetFlowBreak(total, true);*/
            //}
            worksheetForm.ShowDialog();
            this.Close();
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


            }
        }
    }
}
