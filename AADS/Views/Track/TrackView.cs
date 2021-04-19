using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.Track
{
    public partial class TrackView : UserControl
    {
        private TrackData track;
        public TrackView()
        {
            InitializeComponent();
            cmbPosition.SelectedIndex = 0;
            cmbSpeed.SelectedIndex = 0;
            cmbBearing.SelectedIndex = 0;
            cmbHeight.SelectedIndex = 0;
        }
        private void TrackView_Load(object sender, EventArgs e)
        {
            setTrackInfo(null);
            timerUpdate.Start();
        }
        public void setTrackInfo(TrackData track)
        {
            this.track = track;
            if (track != null)
            {
                foreach (Control control in Controls)
                {
                    control.Visible = true;
                }
                lbNumber.Text = track.Number.ToString("000");
                lbCallsign.Text = track.CallSign ?? "";
                if (track.Status == TrackStatus.OverridePending)
                {
                    lbStatus.Text = TrackStatus.Pending.ToString();
                }
                else
                {
                    lbStatus.Text = track.Status.ToString();
                }
                lbPosition.Text = PositionConverter.ParsePointToString(track.Position, cmbPosition.Text);
                lbSpeed.Text = ScaleConverter.ConvertSpeed(track.Speed, "knots", cmbSpeed.Text).ToString("#,##0.####");
                lbBearing.Text = ScaleConverter.ConvertBearing(track.Bearing, "degree", cmbBearing.Text).ToString("#,##0.####");
                if (track.Height.HasValue)
                {
                    lbHeight.Text = ScaleConverter.ConvertHeight(track.Height.Value, "ft", cmbHeight.Text).ToString("#,##0.####");
                }
                else
                {
                    lbHeight.Text = "Unknown";
                }
            }
            else
            {
                foreach (Control control in Controls)
                {
                    control.Visible = false;
                }
                lbNumber.Text = "";
                lbCallsign.Text = "";
                lbStatus.Text = "";
                lbPosition.Text = "";
                lbSpeed.Text = "";
                lbBearing.Text = "";
                lbHeight.Text = "";
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedIndex > -1 && track != null)
            {
                lbPosition.Text = PositionConverter.ParsePointToString(track.Position, cmbPosition.SelectedItem.ToString());
            }
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track != null)
                lbSpeed.Text = ScaleConverter.ConvertSpeed(track.Speed, "knots", cmbSpeed.Text).ToString("#,##0.####");
        }

        private void cmbBearing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track != null)
                lbBearing.Text = ScaleConverter.ConvertBearing(track.Bearing, "degree", cmbBearing.Text).ToString("#,##0.####");
        }

        private void cmbHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track != null && track.Height.HasValue)
                lbHeight.Text = ScaleConverter.ConvertHeight(track.Height.Value, "ft", cmbHeight.Text).ToString("#,##0.####");
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (ControlViews.Track.currentControl == ControlViews.TrackView)
            {
                if (track != null)
                {
                    track = ControlViews.Main.trackHandler.Get(track.Key);
                    setTrackInfo(track);
                }
                else
                {
                    setTrackInfo(null);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (track == null)
            {

            }
            else
            {
                var key = track.Key;
                CommandResponse response = ControlViews.Main.trackHandler.Remove(key);
                if (response.Code == CommandResponseCode.Success)
                {
                    setTrackInfo(null);
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (track == null)
            {

            }
            else
            {
                ControlViews.Track.SetControl(ControlViews.TrackCreation);
                ControlViews.TrackCreation.setEditMode(true);
                ControlViews.TrackCreation.setTrackInfo(track);
            }
        }
    }
}
