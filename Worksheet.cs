using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class Worksheet : Form
    {
        public Worksheet()
        {
            InitializeComponent();

            siticoneVScrollBar1.Value = flowLayoutPanel.VerticalScroll.Value;
            siticoneVScrollBar1.Minimum = flowLayoutPanel.VerticalScroll.Minimum;
            siticoneVScrollBar1.Maximum = flowLayoutPanel.VerticalScroll.Maximum;

            
        }


        private void siticoneVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel.VerticalScroll.Value = siticoneVScrollBar1.Value;
        }

        List<CheckBox> chkBox = new List<CheckBox>();
        List<Label> totalCost = new List<Label>();

        private void Worksheet_Load(object sender, EventArgs e)
        {
            

            foreach (Work workData in MainMenu.WorkSheet)
            {
                
                Label workType = new Label();
                workType.Text = workData.WorkType;
                Label materialCost = new Label();
                materialCost.Text = Convert.ToString(workData.MaterialCost);
                Label time = new Label();
                time.Text = Convert.ToString(workData.TimeReq);
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
                select.Click += new EventHandler(ShowCheckedTotal);
                //flowLayoutPanel.SetFlowBreak(select, true);
                

                /*double time = Convert.ToDouble(dataArray[1]);
                double mateiral = Convert.ToDouble(dataArray[2]);
                Work.MaterialCost.Add(mateiral);
                Work.TimeCost.Add(time);

                Label total = new Label();
                Work.TotalCost.Add(mateiral + (time * 300));

                
                worksheetForm.flowLayoutPanel.Controls.Add(total);
                worksheetForm.flowLayoutPanel.SetFlowBreak(total, true);*/
            }

            


        }
        
        private void ShowCheckedTotal(object sender, System.EventArgs e)
        {
            double material = 0, time = 0;
            for (int i = 0; i < chkBox.Count; i++)
            {
                
                double total = 0;
                //string msg = string.Empty;
                
                if (chkBox[i].Checked && chkBox[i].Enabled)
                {
                    material += MainMenu.WorkSheet[i].MaterialCost;
                    time += MainMenu.WorkSheet[i].TimeReq * 300;
                    total = MainMenu.WorkSheet[i].MaterialCost + (MainMenu.WorkSheet[i].TimeReq * 300);
                    totalCost[i].Text = Convert.ToString(total);
                    
                }
                else
                {
                    totalCost[i].Text = "";
                    
                }
                txtMaterial.Text = Convert.ToString(material);
                txtTime.Text = Convert.ToString(time);
                //MessageBox.Show(msg);
            }  
            
           
        }

        private void Worksheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Worksheet Registeration",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                MainMenu f = new MainMenu();
                //f.worksheetToolStripMenuItem.Enabled = true;
                //f.paymentToolStripMenuItem.Enabled = true;
                
                this.Visible = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Work paymentData = new Work
            {
                MaterialCost = Convert.ToDouble(txtMaterial.Text),
                TimeCost = Convert.ToDouble(txtTime.Text),
                TotalCost = Convert.ToDouble(txtMaterial.Text) + Convert.ToDouble(txtTime.Text),
                Count = 1
            };

            MainMenu.WorkSheet.Add(paymentData);
            MessageBox.Show("Paysheet registered!");

            foreach(CheckBox chk in chkBox)
            {
                chk.Checked = false;
            }
        }
    }
}
