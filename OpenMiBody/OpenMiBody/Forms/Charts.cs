using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace OpenMiBody.Forms
{
    public partial class Charts : Form
    {
        BusinessLogic.MiBodyUser _user;
        public Charts(BusinessLogic.MiBodyUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Draw(string attribute)
        {
            PointPairList list = new PointPairList();
            for (int i =0; i < _user.miBodyDataList.Count(); i++)
            {
                if (_user.miBodyDataList[i]._weightInKG > 0)
                {
                    double date = (double)new XDate(_user.miBodyDataList[i]._dateTime);
                    
                    double value=0.0;
                    switch (attribute)
                    {
                        case "Weight (Kg)":
                            value = _user.miBodyDataList[i]._weightInKG;
                            break;

                        case "Body Fat" :
                            value = _user.miBodyDataList[i]._bodyFat;
                            break;

                        case "BMI":
                            value = _user.miBodyDataList[i]._bmi;
                            break;

                        case "BMR":
                            value = _user.miBodyDataList[i]._bmr;
                            break;

                        case "Muscle Mass":
                            value = _user.miBodyDataList[i]._muscleMass;
                            break;

                    }

                    list.Add(date, value);
                }
            }
            

            GraphPane pane = chart.GraphPane;
            pane.CurveList.Clear();
            pane.XAxis.Title.Text = "Date";
            pane.YAxis.Title.Text = attribute;
            pane.Title.Text = attribute;
            LineItem line = pane.AddCurve(attribute, list, Color.Blue);
            pane.XAxis.Type = AxisType.Date;
            pane.XAxis.Scale.Format = "dd/MM/yy";
            chart.Invalidate();
            chart.AxisChange();
        }


        private void RemoveLine(string field)
        {
            chart.GraphPane.CurveList[field].Clear();            
            chart.Invalidate();
            chart.AxisChange();
        }

        private void rWeight_Click(object sender, EventArgs e)
        {
            Draw(rWeight.Text);
        }

        private void rBodyFat_Click(object sender, EventArgs e)
        {
            Draw(rBodyFat.Text);
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            rWeight_Click(null,null);
        }

        private void rBMI_Click(object sender, EventArgs e)
        {
            Draw(rBMI.Text);
        }

        private void rBMR_Click(object sender, EventArgs e)
        {
            Draw(rBMR.Text);
        }

        private void rMuscleMass_Click(object sender, EventArgs e)
        {
            Draw(rMuscleMass.Text);
        }
    }
}