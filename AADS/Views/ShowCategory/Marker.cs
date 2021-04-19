using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.ShowCategory
{
    public partial class Marker : UserControl
    {
        public Marker()
        {
            InitializeComponent();
            
        }
        public UserControl currentControl;
        public void SetControl(UserControl control)
        {
            currentControl = control;
            panelShowDetail.Controls.Clear();
            panelShowDetail.Controls.Add(currentControl);
        }
        private void btnShowAiport_Click(object sender, EventArgs e)
        {
            SetControl(ControlViews.AirportCreation);
        }

        private void btnShowCity_Click(object sender, EventArgs e)
        {
            SetControl(ControlViews.CityCreation);
        }

        private void btnShowFixedPoint_Click(object sender, EventArgs e)
        {
            SetControl(ControlViews.FixedPointCreation);
        }

        private void btnShowFireUnit_Click(object sender, EventArgs e)
        {
            SetControl(ControlViews.FireUnitCreation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetControl(ControlViews.LandmarkCreation);
        }

        private void btnShowVitalAsset_Click(object sender, EventArgs e)
        {
            SetControl(ControlViews.VitalAssetCreation);
        }

        private void btnShowWeaponBattery_Click(object sender, EventArgs e)
        {

        }
    }
}
