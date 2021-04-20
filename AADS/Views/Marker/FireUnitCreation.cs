using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.Marker
{
    public partial class FireUnitCreation : UserControl
    {
        private MainForm main = MainForm.GetInstance();
        public FireUnitCreation()
        {
            InitializeComponent();
            cmbPosition.SelectedIndex = 0;
        }

        internal void GMap_MouseClick(object sender, MouseEventArgs e)
        {
            PointLatLng point = ControlViews.Main.gMap.FromLocalToLatLng(e.X, e.Y);
            txtLocation.Text = PositionConverter.ParsePointToString(point, cmbPosition.Text);
        }

    }
}
