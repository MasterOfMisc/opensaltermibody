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
            OpenFileDialog dlgOpen = new OpenFileDialog();
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dlgOpen.FileName);
            }

            // http://www.daniweb.com/forums/thread249014.html#

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
                MiBodyUser user = new MiBodyUser();
                user._userSlot = nUserCount + 1;

                int nNumSlotsPerUser = 35;
                for (int nSlotCount = 0; nSlotCount < nNumSlotsPerUser; nSlotCount++)
                {
                    MiBodyData bodyData = new MiBodyData();

                    int nNumBytesInData = 18;
                    for (int nByteCount = 0; nByteCount < nNumBytesInData; nByteCount++)
                    {
                        bodyData._rawData.Add( fileContents[nFileContentsCounter++] );
                    }

                    user.miBodyDataList.Add(bodyData);
                }

                _miBodySystem.miBodyUserList.Add(user);
            }

            MessageBox.Show("Finished Reading in file data!");

            _miBodySystem.FillInUserData();

            PopulateGrid();
        }

        void PopulateGrid()
        {
            foreach (MiBodyUser user in _miBodySystem.miBodyUserList)
            {
                foreach (MiBodyData bd in user.miBodyDataList)
                {
                    if (bd._valid == false)
                        continue;

                    dataGridView1.Rows.Insert(0, bd._userSlot, bd._dateTime, bd._age, bd._heightInCM, bd._weightInKG, bd._bodyFat, bd._visceralFat, bd._bmi, bd._bmr, bd._muscleMass, bd._bodyWater);
                }
            }
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
    }
}
