namespace OpenMiBody.Forms
{
    partial class Charts
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
            this.components = new System.ComponentModel.Container();
            this.chart = new ZedGraph.ZedGraphControl();
            this.cmdClose = new System.Windows.Forms.Button();
            this.attributes = new System.Windows.Forms.Panel();
            this.rMuscleMass = new System.Windows.Forms.RadioButton();
            this.rBMR = new System.Windows.Forms.RadioButton();
            this.rBMI = new System.Windows.Forms.RadioButton();
            this.rBodyFat = new System.Windows.Forms.RadioButton();
            this.rWeight = new System.Windows.Forms.RadioButton();
            this.attributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.ScrollGrace = 0;
            this.chart.ScrollMaxX = 0;
            this.chart.ScrollMaxY = 0;
            this.chart.ScrollMaxY2 = 0;
            this.chart.ScrollMinX = 0;
            this.chart.ScrollMinY = 0;
            this.chart.ScrollMinY2 = 0;
            this.chart.Size = new System.Drawing.Size(582, 483);
            this.chart.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Location = new System.Drawing.Point(620, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // attributes
            // 
            this.attributes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.attributes.Controls.Add(this.rMuscleMass);
            this.attributes.Controls.Add(this.rBMR);
            this.attributes.Controls.Add(this.rBMI);
            this.attributes.Controls.Add(this.rBodyFat);
            this.attributes.Controls.Add(this.rWeight);
            this.attributes.Location = new System.Drawing.Point(615, 50);
            this.attributes.Name = "attributes";
            this.attributes.Size = new System.Drawing.Size(111, 144);
            this.attributes.TabIndex = 3;
            // 
            // rMuscleMass
            // 
            this.rMuscleMass.AutoSize = true;
            this.rMuscleMass.Location = new System.Drawing.Point(15, 105);
            this.rMuscleMass.Name = "rMuscleMass";
            this.rMuscleMass.Size = new System.Drawing.Size(87, 17);
            this.rMuscleMass.TabIndex = 4;
            this.rMuscleMass.TabStop = true;
            this.rMuscleMass.Text = "Muscle Mass";
            this.rMuscleMass.UseVisualStyleBackColor = true;
            this.rMuscleMass.Click += new System.EventHandler(this.rMuscleMass_Click);
            // 
            // rBMR
            // 
            this.rBMR.AutoSize = true;
            this.rBMR.Location = new System.Drawing.Point(15, 82);
            this.rBMR.Name = "rBMR";
            this.rBMR.Size = new System.Drawing.Size(49, 17);
            this.rBMR.TabIndex = 3;
            this.rBMR.TabStop = true;
            this.rBMR.Text = "BMR";
            this.rBMR.UseVisualStyleBackColor = true;
            this.rBMR.Click += new System.EventHandler(this.rBMR_Click);
            // 
            // rBMI
            // 
            this.rBMI.AutoSize = true;
            this.rBMI.Location = new System.Drawing.Point(15, 59);
            this.rBMI.Name = "rBMI";
            this.rBMI.Size = new System.Drawing.Size(44, 17);
            this.rBMI.TabIndex = 2;
            this.rBMI.TabStop = true;
            this.rBMI.Text = "BMI";
            this.rBMI.UseVisualStyleBackColor = true;
            this.rBMI.Click += new System.EventHandler(this.rBMI_Click);
            // 
            // rBodyFat
            // 
            this.rBodyFat.AutoSize = true;
            this.rBodyFat.Location = new System.Drawing.Point(15, 36);
            this.rBodyFat.Name = "rBodyFat";
            this.rBodyFat.Size = new System.Drawing.Size(67, 17);
            this.rBodyFat.TabIndex = 1;
            this.rBodyFat.TabStop = true;
            this.rBodyFat.Text = "Body Fat";
            this.rBodyFat.UseVisualStyleBackColor = true;
            this.rBodyFat.Click += new System.EventHandler(this.rBodyFat_Click);
            // 
            // rWeight
            // 
            this.rWeight.AutoSize = true;
            this.rWeight.Checked = true;
            this.rWeight.Location = new System.Drawing.Point(15, 13);
            this.rWeight.Name = "rWeight";
            this.rWeight.Size = new System.Drawing.Size(81, 17);
            this.rWeight.TabIndex = 0;
            this.rWeight.TabStop = true;
            this.rWeight.Text = "Weight (Kg)";
            this.rWeight.UseVisualStyleBackColor = true;
            this.rWeight.Click += new System.EventHandler(this.rWeight_Click);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 507);
            this.Controls.Add(this.attributes);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.chart);
            this.Name = "Charts";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            this.attributes.ResumeLayout(false);
            this.attributes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl chart;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Panel attributes;
        private System.Windows.Forms.RadioButton rWeight;
        private System.Windows.Forms.RadioButton rBodyFat;
        private System.Windows.Forms.RadioButton rMuscleMass;
        private System.Windows.Forms.RadioButton rBMR;
        private System.Windows.Forms.RadioButton rBMI;

    }
}