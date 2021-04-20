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
    public partial class CityCreation : UserControl
    {
        private MainForm main = MainForm.GetInstance();
        public CityCreation()
        {
            InitializeComponent();
            cmbPosition.SelectedIndex = 0;
        }


        private void CityCreation_Load(object sender, EventArgs e)
        {
            // Load City Interface
        }

        internal void GMap_MouseClick(object sender, MouseEventArgs e)
        {
            PointLatLng point = ControlViews.Main.gMap.FromLocalToLatLng(e.X, e.Y);
            txtPosition.Text = PositionConverter.ParsePointToString(point, cmbPosition.Text);
        }
    }
}
