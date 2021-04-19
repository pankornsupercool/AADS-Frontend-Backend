using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace AADS
{
    public class GMarkerTrack : GMapMarker
    {
        private TrackData _Track;
        private Point[] Arrow = new Point[] { new Point(-8, 8), new Point(0, -22), new Point(8, 8), new Point(0, 2) };
        private readonly GMapControl map = ControlViews.Main.gMap;

        public GMarkerTrack(TrackData track) : base(track.Position)
        {
            this._Track = track;
        }
        public TrackData Track
        {
            get => _Track;
            set
            {
                this._Track = value;
                Position = value.Position;
            }
        }
        public Brush PlaneColor
        {
            get
            {
                if (Track.Status == TrackStatus.Friendly)
                {
                    return new SolidBrush(Color.FromArgb(255, Color.DarkGreen));
                }
                else if (Track.Status == TrackStatus.Hostile)
                {
                    return new SolidBrush(Color.FromArgb(255, Color.Red));
                }
                else
                {
                    return new SolidBrush(Color.FromArgb(255, Color.Gray));
                }
            }
        }
        private Pen TailColor
        {
            get => new Pen(PlaneColor, 2);
        }
        private Brush CaptionColor
        {
            get
            {
                bool provider = map.NegativeMode;
                if (provider == false)
                {
                    return Brushes.Black;
                }
                return Brushes.White;
            }
        }
        private double Length
        {
            get
            {
                var speed = Track.Speed;
                if (speed >= 125 && speed <= 300)
                {
                    return 2;
                }
                else if (speed > 300 && speed <= 550)
                {
                    return 3.5;
                }
                else if (speed > 550 && speed <= 2000)
                {
                    return 5.5;
                }
                else if (speed > 2000)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
        public override void OnRender(Graphics g)
        {
            Font font = new Font("Angsana New", 14, FontStyle.Bold);
            double angle = ((Track.Bearing + 180) % 360) * Math.PI / 180;
            GPoint start = new GPoint(LocalPosition.X, LocalPosition.Y);
            double deltaX = Length * Math.Sin(angle);
            double deltaY = Length * Math.Cos(angle);
            GPoint end = new GPoint((int)(start.X + deltaX * 5), (int)(start.Y - deltaY * 5));
            g.DrawLine(TailColor, start.X, start.Y, end.X, end.Y);
            var stringSize = g.MeasureString(Track.CallSign, font);
            var localPoint = new PointF((LocalPosition.X + 20) - (stringSize.Width / 2), (LocalPosition.Y - 5) + (stringSize.Height / 2));
            g.DrawString(Track.CallSign, font, CaptionColor, localPoint);

            Matrix temp = g.Transform;
            g.TranslateTransform(start.X, start.Y);
            g.RotateTransform((float)Track.Bearing - Overlay.Control.Bearing);
            g.FillPolygon(PlaneColor, Arrow);
            g.Transform = temp;
        }
    }

}
