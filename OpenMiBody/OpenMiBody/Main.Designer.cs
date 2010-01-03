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
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(12, 12);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(127, 27);
            this.buttonReadFile.TabIndex = 0;
            this.buttonReadFile.Text = "Read USB File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Location = new System.Drawing.Point(145, 12);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(130, 27);
            this.buttonExportExcel.TabIndex = 2;
            this.buttonExportExcel.Text = "Export To Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(281, 12);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(89, 26);
            this.buttonGraph.TabIndex = 3;
            this.buttonGraph.Text = "Graph!";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(712, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(100, 26);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 230);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColumnUser
            // 
            this.ColumnUser.HeaderText = "User";
            this.ColumnUser.Name = "ColumnUser";
            // 
            // ColumnDateTime
            // 
            this.ColumnDateTime.HeaderText = "Date/Time";
            this.ColumnDateTime.Name = "ColumnDateTime";
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.HeaderText = "Height";
            this.ColumnHeight.Name = "ColumnHeight";
            // 
            // ColumnWeight
            // 
            this.ColumnWeight.HeaderText = "Weight";
            this.ColumnWeight.Name = "ColumnWeight";
            // 
            // ColumnBodyFat
            // 
            this.ColumnBodyFat.HeaderText = "Body Fat";
            this.ColumnBodyFat.Name = "ColumnBodyFat";
            // 
            // ColumnVisceralFat
            // 
            this.ColumnVisceralFat.HeaderText = "Visceral Fat";
            this.ColumnVisceralFat.Name = "ColumnVisceralFat";
            // 
            // ColumnBMI
            // 
            this.ColumnBMI.HeaderText = "BMI";
            this.ColumnBMI.Name = "ColumnBMI";
            // 
            // ColumnBMR
            // 
            this.ColumnBMR.HeaderText = "BMR (Kcal)";
            this.ColumnBMR.Name = "ColumnBMR";
            // 
            // ColumnMuscleMass
            // 
            this.ColumnMuscleMass.HeaderText = "Muscle Mass %";
            this.ColumnMuscleMass.Name = "ColumnMuscleMass";
            // 
            // ColumnBodyWater
            // 
            this.ColumnBodyWater.HeaderText = "Body Water %";
            this.ColumnBodyWater.Name = "ColumnBodyWater";
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
            this.comboBoxUserSelect.Location = new System.Drawing.Point(659, 65);
            this.comboBoxUserSelect.Name = "comboBoxUserSelect";
            this.comboBoxUserSelect.Size = new System.Drawing.Size(153, 24);
            this.comboBoxUserSelect.TabIndex = 6;
            this.comboBoxUserSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select User";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Total Weight Lost";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUserSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.buttonReadFile);
            this.Name = "Form1";
            this.Text = "Open MiBody!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.ComboBox comboBoxUserSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
    }
}

