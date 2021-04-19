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
    public partial class VitalAssetCreation : UserControl
    {
        private MainForm main = MainForm.GetInstance();
        public VitalAssetCreation()
        {
            InitializeComponent();
            cmbPosition.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
        }

        private void VitalAssetCreation_Load(object sender, EventArgs e)
        {

        }
        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedIndex > -1 && txtPosition.Text != "")
            {
                PointLatLng point = PositionConverter.ParsePointFromString(txtPosition.Text);
                txtPosition.Text = PositionConverter.ParsePointToString(point, cmbPosition.Text);
            }
        }
        public void GMap_MouseClick(object sender, MouseEventArgs e)
        {
            PointLatLng point = ControlViews.Main.gMap.FromLocalToLatLng(e.X, e.Y);
            txtPosition.Text = PositionConverter.ParsePointToString(point, cmbPosition.Text);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            PointLatLng point = PositionConverter.ParsePointFromString(txtPosition.Text);
            if (point.IsEmpty)
            {
                // Error on parsing position
                MessageBox.Show("Error");
            }
            else
            {
                // TODO : Selecting image to display as marker
                Image image = Image.FromFile("Images/icon/VitalAsset.png");
                GMarker marker = new GMarker(point, name, image);
                GMarkerRect rect = new GMarkerRect(marker);
                // TODO : Manage data before adding to overlay
                main.markerOverlay.Markers.Add(marker);
                main.markerOverlay.Markers.Add(rect);
            }
        }
    }
}
