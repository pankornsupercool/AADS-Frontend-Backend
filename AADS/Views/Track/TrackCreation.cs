using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.Track
{
    public partial class TrackCreation : UserControl
    {
        private TrackData track;
        private PointLatLng point;
        private string speedScale;
        private string bearingScale;
        private string heightScale;
        private bool editMode = false;
        public TrackCreation()
        {
            InitializeComponent();
            cmbPosition.SelectedIndex = 0;
            TrackStatuses.Values.ToList().ForEach(x => cmbStatus.Items.Add(x));
            cmbStatus.SelectedIndex = 0;
            cmbSpeed.SelectedIndex = 0;
            cmbBearing.SelectedIndex = 0;
            cmbHeight.SelectedIndex = 0;
            speedScale = cmbSpeed.SelectedItem.ToString();
            bearingScale = cmbBearing.SelectedItem.ToString();
            heightScale = cmbHeight.SelectedItem.ToString();
            txtPosition.Text = "";
        }
        private void TrackCreation_Load(object sender, EventArgs e)
        {
            timerUpdate.Start();
        }

        public void GMap_MouseClick(object sender, MouseEventArgs e)
        {
            if ((track != null && track.Faker) || !editMode)
            {
                PointLatLng point = ControlViews.Main.gMap.FromLocalToLatLng(e.X, e.Y);
                this.point = point;
                txtPosition.Text = PositionConverter.ParsePointToString(point, cmbPosition.SelectedItem.ToString());
            }
        }
        public void setEditMode(bool editMode)
        {
            this.editMode = editMode;
            if (editMode)
            {
                txtNumber.ReadOnly = true;
                btnCreate.Text = "ยืนยันการแก้ไข";
            }
            else
            {
                txtNumber.ReadOnly = false;
                cmbStatus.SelectedIndex = 0;
                btnCreate.Text = "สร้าง";
                clearFields();
            }
        }
        public void setTrackInfo(TrackData track)
        {
            this.track = track;
            if (track != null)
            {
                txtNumber.Text = track.Number.ToString("000");
                txtCallSign.Text = track.CallSign;
                cmbStatus.Text = track.Status.ToString();
                txtPosition.Text = PositionConverter.ParsePointToString(track.Position, cmbPosition.Text);
                txtSpeed.Text = ScaleConverter.ConvertSpeed(track.Speed, "knots", cmbSpeed.Text).ToString();
                txtBearing.Text = ScaleConverter.ConvertBearing(track.Bearing, "degree", cmbBearing.Text).ToString();
                txtCallSign.ReadOnly = false;
                txtPosition.ReadOnly = txtSpeed.ReadOnly = txtBearing.ReadOnly = txtHeight.ReadOnly = !track.Faker;
                if (track.Height.HasValue)
                {
                    txtHeight.Text = ScaleConverter.ConvertHeight(track.Height.Value, "ft", cmbHeight.Text).ToString();
                }
                else
                {
                    txtHeight.Text = "Unknown";
                    txtHeight.ReadOnly = true;
                }
            }
            else
            {
                clearFields();
            }
        }
        public void refreshTrackInfo(TrackData track)
        {
            this.track = track;
            if (track != null)
            {
                txtNumber.Text = track.Number.ToString("000");
                if (!track.Faker)
                {
                    txtPosition.Text = PositionConverter.ParsePointToString(track.Position, cmbPosition.Text);
                    txtSpeed.Text = ScaleConverter.ConvertSpeed(track.Speed, "knots", cmbSpeed.Text).ToString();
                    txtBearing.Text = ScaleConverter.ConvertBearing(track.Bearing, "degree", cmbBearing.Text).ToString();
                    txtCallSign.ReadOnly = false;
                    txtPosition.ReadOnly = txtSpeed.ReadOnly = txtBearing.ReadOnly = txtHeight.ReadOnly = true;
                    if (track.Height.HasValue)
                    {
                        txtHeight.Text = ScaleConverter.ConvertHeight(track.Height.Value, "ft", cmbHeight.Text).ToString();
                    }
                    else
                    {
                        txtHeight.Text = "Unknown";
                    }
                }
            }
        }
        public void clearFields()
        {
            txtCallSign.ReadOnly = false;
            txtPosition.ReadOnly = false;
            txtSpeed.ReadOnly = false;
            txtBearing.ReadOnly = false;
            txtHeight.ReadOnly = false;
            txtNumber.Text = "";
            txtCallSign.Text = "";
            txtPosition.Text = "";
            txtSpeed.Text = "";
            txtBearing.Text = "";
            txtHeight.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            PointLatLng point = PositionConverter.ParsePointFromString(txtPosition.Text);
            int number;
            double speed, bearing, height;
            if (point.IsEmpty)
            {

            }
            else if (!int.TryParse(txtNumber.Text, out number))
            {

            }
            else if (!double.TryParse(txtSpeed.Text, out speed))
            {

            }
            else if (!double.TryParse(txtBearing.Text, out bearing))
            {

            }
            else if (!double.TryParse(txtHeight.Text, out height) && txtHeight.Text != "Unknown")
            {

            }
            else
            {
                var track = new TrackData
                {
                    CallSign = txtCallSign.Text.ToUpper(),
                    Status = (TrackStatus)Enum.Parse(typeof(TrackStatus), cmbStatus.Text),
                    Number = number,
                    Position = point,
                    Speed = ScaleConverter.ConvertSpeed(speed, speedScale, "knots"),
                    Bearing = ScaleConverter.ConvertBearing(bearing, bearingScale, "degree"),
                    LastUpdated = DateTime.Now
                };
                if (editMode)
                {
                    if (this.track != null)
                    {
                        track.Faker = this.track.Faker;
                        if (txtHeight.Text != "Unknown") track.Height = ScaleConverter.ConvertHeight(height, heightScale, "ft");
                        if (txtCallSign.Text == "") track.CallSign = null;
                        if (track.Status == TrackStatus.Pending) track.Status = TrackStatus.OverridePending;
                        CommandResponse response = ControlViews.Main.trackHandler.Update(track);
                        if (response.Code == CommandResponseCode.Success)
                        {
                            ControlViews.Track.SetControl(ControlViews.TrackView);
                            ControlViews.TrackView.setTrackInfo(track);
                        }
                        else
                        {
                            MessageBox.Show(response.Message);
                        }
                    }
                }
                else
                {
                    track.Faker = true;
                    track.Height = ScaleConverter.ConvertHeight(height, heightScale, "ft");
                    CommandResponse response = ControlViews.Main.trackHandler.Create(track);
                    if (response.Code == CommandResponseCode.Success)
                    {
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show(response.Message);
                    }
                }
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedIndex > -1 && txtPosition.Text != "")
            {
                txtPosition.Text = PositionConverter.ParsePointToString(point, cmbPosition.SelectedItem.ToString());
            }
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newScale = cmbSpeed.SelectedItem.ToString();
            double speed;
            if (double.TryParse(txtSpeed.Text, out speed))
            {
                double newvalue = ScaleConverter.ConvertSpeed(speed, speedScale, newScale);
                txtSpeed.Text = newvalue.ToString();
            }
            speedScale = newScale;
        }

        private void cmbBearing_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newScale = cmbBearing.SelectedItem.ToString();
            double bearing;
            if (double.TryParse(txtBearing.Text, out bearing))
            {
                double newvalue = ScaleConverter.ConvertBearing(bearing, bearingScale, newScale);
                txtBearing.Text = newvalue.ToString();
            }
            bearingScale = newScale;
        }

        private void cmbHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newScale = cmbHeight.SelectedItem.ToString();
            double height;
            if (double.TryParse(txtHeight.Text, out height))
            {
                double newvalue = ScaleConverter.ConvertHeight(height, heightScale, newScale);
                txtHeight.Text = newvalue.ToString();
            }
            heightScale = newScale;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (ControlViews.Track.currentControl == ControlViews.TrackCreation && editMode)
            {
                if (track != null)
                {
                    track = ControlViews.Main.trackHandler.Get(track.Key);
                    refreshTrackInfo(track);
                }
                else
                {
                    setTrackInfo(null);
                }
            }
        }
    }
}
