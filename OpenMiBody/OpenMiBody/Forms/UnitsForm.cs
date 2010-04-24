using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMiBody.BusinessLogic;

namespace OpenMiBody.Forms
{
    public partial class UnitsForm : Form
    {
        public Weight _weight;
        public HeightMeasure _height;

        public UnitsForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxWeight.SelectedItem == "Kilogrames (Kg)")
                _weight = Weight.Kilogrames;

            if (comboBoxWeight.SelectedItem == "Pounds (LB)")
                _weight = Weight.PoundsLB;

            if (comboBoxWeight.SelectedItem == "Stone (ST)")
                _weight = Weight.Stone;

            if (comboBoxHeight.SelectedItem == "Centimetre (cm)")
                _height = HeightMeasure.Centimetres;

            if (comboBoxHeight.SelectedItem == "Inches")
                _height = HeightMeasure.Inches;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void UnitsForm_Load(object sender, EventArgs e)
        {
            comboBoxWeight.SelectedIndex = 0;
            comboBoxHeight.SelectedIndex = 0;
        }

        private void comboBoxWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
