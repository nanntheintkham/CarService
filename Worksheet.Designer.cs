using System.Windows.Forms;

namespace CarService
{
    partial class Worksheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneVScrollBar1 = new Siticone.Desktop.UI.WinForms.SiticoneVScrollBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(4, 7);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.flowLayoutPanel.Size = new System.Drawing.Size(740, 461);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaterial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(4, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(488, 30);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(97, 33);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Time Costs";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(136, 34);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 26);
            this.txtMaterial.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Material Costs";
            // 
            // siticoneVScrollBar1
            // 
            this.siticoneVScrollBar1.InUpdate = false;
            this.siticoneVScrollBar1.LargeChange = 10;
            this.siticoneVScrollBar1.Location = new System.Drawing.Point(746, 8);
            this.siticoneVScrollBar1.Name = "siticoneVScrollBar1";
            this.siticoneVScrollBar1.ScrollbarSize = 23;
            this.siticoneVScrollBar1.Size = new System.Drawing.Size(23, 460);
            this.siticoneVScrollBar1.TabIndex = 3;
            this.siticoneVScrollBar1.ThumbSize = 350F;
            this.siticoneVScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneVScrollBar1_Scroll);
            // 
            // Worksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 550);
            this.Controls.Add(this.siticoneVScrollBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "Worksheet";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Worksheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private GroupBox groupBox1;
        private Button btnRegister;
        private TextBox textBox1;
        private Label label6;
        private TextBox txtMaterial;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneVScrollBar siticoneVScrollBar1;
    }
}