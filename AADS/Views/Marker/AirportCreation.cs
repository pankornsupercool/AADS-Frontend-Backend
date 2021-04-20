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
    /*public struct AirportDetail
    {
        public string Name;
        public string Detail;
        public AirportDetail(string name, string detail)
        {
            Name = name;
            Detail = detail;
        }
    }*/
    public partial class AirportCreation : UserControl
    {
        private MainForm main = MainForm.GetInstance();
        public AirportCreation()
        {
            InitializeComponent();
            cmbPosition.SelectedIndex = 0;
        }
        private void AirportCreation_Load(object sender, EventArgs e)
        {
        }

        internal void GMap_MouseClick(object sender, MouseEventArgs e)
        {
            PointLatLng point = ControlViews.Main.gMap.FromLocalToLatLng(e.X, e.Y);
            txtPosition.Text = PositionConverter.ParsePointToString(point, cmbPosition.Text);
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
