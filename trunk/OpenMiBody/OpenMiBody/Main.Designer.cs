namespace OpenMiBody
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonReadUSBFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGraphProgress = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonChangeUnits = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTargetWeight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonWeightCalc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.gradientPanel1 = new ECPApp.GradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBodyFat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVisceralFat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBMR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMuscleMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBodyWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxUserSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1065, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReadUSBFile,
            this.toolStripSeparator1,
            this.toolStripButtonAddUser,
            this.toolStripButtonAbout,
            this.toolStripSeparator2,
            this.toolStripButtonGraphProgress,
            this.toolStripButtonChangeUnits,
            this.toolStripButtonTargetWeight,
            this.toolStripButtonWeightCalc,
            this.toolStripSeparator3,
            this.toolStripButtonExport,
            this.toolStripButtonSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1065, 55);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonReadUSBFile
            // 
            this.toolStripButtonReadUSBFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReadUSBFile.Image = global::OpenMiBody.Properties.Resources.usb_stick_accept;
            this.toolStripButtonReadUSBFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonReadUSBFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReadUSBFile.Name = "toolStripButtonReadUSBFile";
            this.toolStripButtonReadUSBFile.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonReadUSBFile.Text = "Read USB File";
            this.toolStripButtonReadUSBFile.Click += new System.EventHandler(this.toolStripButtonReadUSBFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonAddUser
            // 
            this.toolStripButtonAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUser.Image = global::OpenMiBody.Properties.Resources.users_add;
            this.toolStripButtonAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUser.Name = "toolStripButtonAddUser";
            this.toolStripButtonAddUser.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonAddUser.Text = "User Preferences";
            this.toolStripButtonAddUser.Visible = false;
            this.toolStripButtonAddUser.Click += new System.EventHandler(this.toolStripButtonAddUser_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = global::OpenMiBody.Properties.Resources.info;
            this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonAbout.Text = "About!";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolStripButtonGraphProgress
            // 
            this.toolStripButtonGraphProgress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGraphProgress.Image = global::OpenMiBody.Properties.Resources.chart;
            this.toolStripButtonGraphProgress.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonGraphProgress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGraphProgress.Name = "toolStripButtonGraphProgress";
            this.toolStripButtonGraphProgress.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonGraphProgress.Text = "Graph Progress";
            this.toolStripButtonGraphProgress.Click += new System.EventHandler(this.toolStripButtonGraphProgress_Click);
            // 
            // toolStripButtonChangeUnits
            // 
            this.toolStripButtonChangeUnits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChangeUnits.Image = global::OpenMiBody.Properties.Resources.ruler;
            this.toolStripButtonChangeUnits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonChangeUnits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangeUnits.Name = "toolStripButtonChangeUnits";
            this.toolStripButtonChangeUnits.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonChangeUnits.Text = "Change Units";
            this.toolStripButtonChangeUnits.Click += new System.EventHandler(this.toolStripButtonChangeUnits_Click);
            // 
            // toolStripButtonTargetWeight
            // 
            this.toolStripButtonTargetWeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTargetWeight.Image = global::OpenMiBody.Properties.Resources.calendar_date;
            this.toolStripButtonTargetWeight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonTargetWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTargetWeight.Name = "toolStripButtonTargetWeight";
            this.toolStripButtonTargetWeight.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonTargetWeight.Text = "Target Weight";
            this.toolStripButtonTargetWeight.Visible = false;
            this.toolStripButtonTargetWeight.Click += new System.EventHandler(this.toolStripButtonTargetWeight_Click);
            // 
            // toolStripButtonWeightCalc
            // 
            this.toolStripButtonWeightCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonWeightCalc.Image = global::OpenMiBody.Properties.Resources.calculator;
            this.toolStripButtonWeightCalc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonWeightCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWeightCalc.Name = "toolStripButtonWeightCalc";
            this.toolStripButtonWeightCalc.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonWeightCalc.Text = "Weight Calculator";
            this.toolStripButtonWeightCalc.Visible = false;
            this.toolStripButtonWeightCalc.Click += new System.EventHandler(this.toolStripButtonWeightCalc_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonExport
            // 
            this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExport.Image = global::OpenMiBody.Properties.Resources.database_next;
            this.toolStripButtonExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExport.Name = "toolStripButtonExport";
            this.toolStripButtonExport.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonExport.Text = "Export To Excel";
            this.toolStripButtonExport.Click += new System.EventHandler(this.toolStripButtonExport_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = global::OpenMiBody.Properties.Resources.process;
            this.toolStripButtonSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonSettings.Text = "toolStripButtonSettings";
            this.toolStripButtonSettings.Visible = false;
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel1.BackgroundImage")));
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel1.Controls.Add(this.dataGridView1);
            this.gradientPanel1.Controls.Add(this.comboBoxUserSelect);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 55);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.PageEndColor = System.Drawing.Color.Empty;
            this.gradientPanel1.PageStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(212)))));
            this.gradientPanel1.Size = new System.Drawing.Size(1065, 370);
            this.gradientPanel1.TabIndex = 12;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUser,
            this.ColumnDateTime,
            this.ColumnAge,
            this.ColumnHeight,
            this.ColumnWeight,
            this.ColumnBodyFat,
            this.ColumnVisceralFat,
            this.ColumnBMI,
            this.ColumnBMR,
            this.ColumnMuscleMass,
            this.ColumnBodyWater});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 288);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColumnUser
            // 
            this.ColumnUser.HeaderText = "User";
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            // 
            // ColumnDateTime
            // 
            this.ColumnDateTime.HeaderText = "Date/Time";
            this.ColumnDateTime.Name = "ColumnDateTime";
            this.ColumnDateTime.ReadOnly = true;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.HeaderText = "Height";
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.ReadOnly = true;
            // 
            // ColumnWeight
            // 
            this.ColumnWeight.HeaderText = "Weight";
            this.ColumnWeight.Name = "ColumnWeight";
            this.ColumnWeight.ReadOnly = true;
            // 
            // ColumnBodyFat
            // 
            this.ColumnBodyFat.HeaderText = "Body Fat";
            this.ColumnBodyFat.Name = "ColumnBodyFat";
            this.ColumnBodyFat.ReadOnly = true;
            // 
            // ColumnVisceralFat
            // 
            this.ColumnVisceralFat.HeaderText = "Visceral Fat";
            this.ColumnVisceralFat.Name = "ColumnVisceralFat";
            this.ColumnVisceralFat.ReadOnly = true;
            // 
            // ColumnBMI
            // 
            this.ColumnBMI.HeaderText = "BMI";
            this.ColumnBMI.Name = "ColumnBMI";
            this.ColumnBMI.ReadOnly = true;
            // 
            // ColumnBMR
            // 
            this.ColumnBMR.HeaderText = "BMR (Kcal)";
            this.ColumnBMR.Name = "ColumnBMR";
            this.ColumnBMR.ReadOnly = true;
            // 
            // ColumnMuscleMass
            // 
            this.ColumnMuscleMass.HeaderText = "Muscle Mass %";
            this.ColumnMuscleMass.Name = "ColumnMuscleMass";
            this.ColumnMuscleMass.ReadOnly = true;
            // 
            // ColumnBodyWater
            // 
            this.ColumnBodyWater.HeaderText = "Body Water %";
            this.ColumnBodyWater.Name = "ColumnBodyWater";
            this.ColumnBodyWater.ReadOnly = true;
            // 
            // comboBoxUserSelect
            // 
            this.comboBoxUserSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUserSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserSelect.FormattingEnabled = true;
            this.comboBoxUserSelect.Items.AddRange(new object[] {
            "All",
            "User 01",
            "User 02",
            "User 03",
            "User 04",
            "User 05",
            "User 06",
            "User 07",
            "User 08",
            "User 09",
            "User 10",
            "User 11",
            "User 12"});
            this.comboBoxUserSelect.Location = new System.Drawing.Point(897, 17);
            this.comboBoxUserSelect.Name = "comboBoxUserSelect";
            this.comboBoxUserSelect.Size = new System.Drawing.Size(153, 24);
            this.comboBoxUserSelect.TabIndex = 6;
            this.comboBoxUserSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(810, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Open MiBody!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxUserSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonReadUSBFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonGraphProgress;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangeUnits;
        private System.Windows.Forms.ToolStripButton toolStripButtonWeightCalc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonTargetWeight;
        private System.Windows.Forms.ToolStripButton toolStripButtonExport;
        private ECPApp.GradientPanel gradientPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBodyFat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVisceralFat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBMR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMuscleMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBodyWater;
    }
}

