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
    public partial class FixedPointCreation : UserControl
    {
        private MainForm main = MainForm.GetInstance();
        public FixedPointCreation()
        {
            InitializeComponent();
            cmbPosition.SelectedIndex = 0;
        }

        internal void GMap_MouseClick(object sender, MouseEventArgs e)
        {
            PointLatLng point = ControlViews.Main.gMap.FromLocalToLatLng(e.X, e.Y);
            txtPosition.Text = PositionConverter.ParsePointToString(point, cmbPosition.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMarker_Click(object sender, EventArgs e)
        {
            // Marker detail
            List<object> Detail = new List<object>();
            Detail.Add("Airport");
            Detail.Add("Detail");
            Detail.Add("latLng");
            // *** Remove comment -> add marker to dictionary ***
            //main.detailMarkers.Add(GMarker, Detail);
        }
    }
}
