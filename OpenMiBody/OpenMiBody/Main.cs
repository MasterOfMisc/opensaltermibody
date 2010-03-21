using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OpenMiBody.BusinessLogic;
using OpenMiBody.Forms;

namespace OpenMiBody
{
    public partial class Form1 : Form
    {
        MiBodySystem _miBodySystem = new MiBodySystem();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
        }

        void PopulateGrid()
        {
            dataGridView1.Rows.Clear();

            foreach (MiBodyUser user in _miBodySystem.miBodyUserList)
            {
                foreach (MiBodyData bd in user.miBodyDataList)
                {
                    if (bd._valid == false)
                        continue;

                    int nNewRow = dataGridView1.Rows.Add();

                    dataGridView1.Rows[nNewRow].Tag = bd;
                    dataGridView1.Rows[nNewRow].Cells[0].Value = bd._userSlot;
                    dataGridView1.Rows[nNewRow].Cells[1].Value = bd._dateTime; 
                    dataGridView1.Rows[nNewRow].Cells[2].Value = bd._age; 
                    dataGridView1.Rows[nNewRow].Cells[3].Value = string.Format("{0} cm", bd._heightInCM); 
                    dataGridView1.Rows[nNewRow].Cells[4].Value = string.Format("{0} Kg", bd._weightInKG); 
                    dataGridView1.Rows[nNewRow].Cells[5].Value = string.Format("{0} %", bd._bodyFat); 
                    dataGridView1.Rows[nNewRow].Cells[6].Value = bd._visceralFat; 
                    dataGridView1.Rows[nNewRow].Cells[7].Value = bd._bmi; 
                    dataGridView1.Rows[nNewRow].Cells[8].Value = bd._bmr; 
                    dataGridView1.Rows[nNewRow].Cells[9].Value = string.Format("{0} %", bd._muscleMass); 
                    dataGridView1.Rows[nNewRow].Cells[10].Value = string.Format("{0} %", bd._bodyWater);

                    //dataGridView1.Rows.Insert(0, bd._userSlot, bd._dateTime, bd._age, bd._heightInCM, bd._weightInKG, bd._bodyFat, bd._visceralFat, bd._bmi, bd._bmr, bd._muscleMass, bd._bodyWater);
                }
            }

            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("todo");
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            MessageBox.Show("todo");
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("todo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Open MiBody V0.03 (BETA)";
            SetupDataGridView(ref dataGridView1);

            try
            {
                _miBodySystem = (MiBodySystem)MiBodySystemSerialization.ReadXMLFileToObject("MiBodyUserData.xml");
            }
            catch (Exception ex)
            {
            }

            PopulateGrid();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            WelcomeForm dlg = new WelcomeForm();
            dlg.ShowDialog();
        }

        public void SetupDataGridView(ref DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;

            // Setting the style of the DataGridView control
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgv.DefaultCellStyle.BackColor = Color.Empty;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.AllowUserToAddRows = false;
        }

        private void comboBoxUserSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUserSelect.Text == "User 01")
                HideShowRows(1);
            if (comboBoxUserSelect.Text == "User 02")
                HideShowRows(2);
            if (comboBoxUserSelect.Text == "User 03")
                HideShowRows(3);
            if (comboBoxUserSelect.Text == "User 04")
                HideShowRows(4);
            if (comboBoxUserSelect.Text == "User 05")
                HideShowRows(5);
            if (comboBoxUserSelect.Text == "User 06")
                HideShowRows(6); 
            if (comboBoxUserSelect.Text == "User 07")
                HideShowRows(7);
            if (comboBoxUserSelect.Text == "User 08")
                HideShowRows(8); 
            if (comboBoxUserSelect.Text == "User 09")
                HideShowRows(9);
            if (comboBoxUserSelect.Text == "User 10")
                HideShowRows(10);
            if (comboBoxUserSelect.Text == "User 11")
                HideShowRows(11);
            if (comboBoxUserSelect.Text == "User 12")
                HideShowRows(12); 
        }

        void HideShowRows(int userSlotToDisplay)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                MiBodyData bd = (MiBodyData)dataGridView1.Rows[i].Tag;

                if (bd._userSlot == userSlotToDisplay)
                    dataGridView1.Rows[i].Visible = true;
                else
                    dataGridView1.Rows[i].Visible = false;
            }
        }

        private void buttonUnits_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonReadUSBFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            if (dlgOpen.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            List<byte> fileContents = new List<byte>();
            int pos = 0;
            string FilePath = dlgOpen.FileName;
            fileContents.Clear();
            if (FilePath != "")
            {
                try
                {
                    using (BinaryReader b = new BinaryReader(File.Open(FilePath, FileMode.Open)))
                    {
                        int length = (int)b.BaseStream.Length;
                        while (pos < length)
                        {
                            fileContents.Add(b.ReadByte());
                            pos++;
                        }
                        b.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }

            // There are 12 users in the system. Each user has a maximum of 35 slots. Each slot contains the data.
            // This data is made up of 18 bytes. Read each of them in to MiBodyData class.

            int nFileContentsCounter = 0;
            int nNumUsers = 12;
            for (int nUserCount = 0; nUserCount < nNumUsers; nUserCount++)
            {
                MiBodyUser user = _miBodySystem.GetUser(nUserCount + 1);
                user._userSlot = nUserCount + 1;

                int nNumSlotsPerUser = 35;
                for (int nSlotCount = 0; nSlotCount < nNumSlotsPerUser; nSlotCount++)
                {
                    MiBodyData bodyData = new MiBodyData();

                    int nNumBytesInData = 18;
                    for (int nByteCount = 0; nByteCount < nNumBytesInData; nByteCount++)
                    {
                        bodyData._rawData.Add(fileContents[nFileContentsCounter++]);
                    }

                    if (IsRawDataValid(bodyData) == true)
                    {
                        // Calc Date/Time from raw data. If this already exists then omit it from readings!
                        DateTime dt = _miBodySystem.DecodeDateTimeFromRawData(bodyData);
                        if ( _miBodySystem.CheckDateTimeExists(dt, user) == false )
                            user.miBodyDataList.Add(bodyData);
                    }
                }

                _miBodySystem.AddUser(user);
            }

            MessageBox.Show("Successfully Finished Reading in file data!");

            _miBodySystem.FillInUserData();

            PopulateGrid();
        }


        private bool IsRawDataValid(MiBodyData bd)
        {
            int nonZeroCount = 0;
            foreach (byte b in bd._rawData)
            {
                if (b != 0)
                    nonZeroCount++;
            }

            if (nonZeroCount < 5)
                return false;
            else
                return true;
            
            //return Convert.ToBoolean(nonZeroCount);
        }

        private void toolStripButtonAddUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New User Wizard here! Enter target weight, etc");
        }

        private void toolStripButtonGraphProgress_Click(object sender, EventArgs e)
        {
            int val = comboBoxUserSelect.SelectedIndex - 1;
            if (val > 0)
            {
                MiBodyUser user = _miBodySystem.miBodyUserList[val];

                Charts chart = new Charts(user);
                chart.Show();
            }

        }

        private void toolStripButtonChangeUnits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Units Here");

            UnitsForm dlg = new UnitsForm();
            dlg.ShowDialog();
        }

        private void toolStripButtonTargetWeight_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Display User Target Statistics here!");
        }

        private void toolStripButtonWeightCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Display Weight Calculations here!");
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export To Excel!");
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Settings");
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Free Icons from www.dryicons.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiBodySystemSerialization.WriteObjectToXMLFile(_miBodySystem, "MiBodyUserData.xml");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
