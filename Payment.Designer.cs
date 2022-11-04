namespace CarService
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // txtCount
            // 
            this.txtCount.ForeColor = System.Drawing.Color.Coral;
            this.txtCount.Location = new System.Drawing.Point(195, 27);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(133, 26);
            this.txtCount.TabIndex = 4;
            // 
            // txtMaterial
            // 
            this.txtMaterial.ForeColor = System.Drawing.Color.Olive;
            this.txtMaterial.Location = new System.Drawing.Point(195, 83);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(133, 26);
            this.txtMaterial.TabIndex = 5;
            // 
            // txtService
            // 
            this.txtService.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtService.Location = new System.Drawing.Point(195, 139);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(133, 26);
            this.txtService.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtTotal.Location = new System.Drawing.Point(195, 193);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(133, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 356);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payment_FormClosing);
            this.Load += new System.EventHandler(this.Payment_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtTotal;
    }
}