using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    public class GMarkerRadar : GMapMarker
    {
        public static Size ImageSize = new Size(38, 38);
        private RadarSite _Radar { get; set; }
        public GMapPolygon RadiusPolygon { get; set; }
        public bool IsRadiusShow { get; set; }
        public bool LockPolygon { get; set; }
        private Image _Image;
        private readonly GMapControl map = ControlViews.Main.gMap;
        public GMarkerRadar(RadarSite Radar) : base(Radar.Position)
        {
            this.Radar = Radar;
            IsRadiusShow = false;
            LockPolygon = false;
            _Image = new Bitmap(Image.FromFile("Images/icon/Radar.png"), ImageSize);
            RenewRadius();
        }
        public RadarSite Radar
        {
            get => _Radar;
            set
            {
                _Radar = value;
                Position = value.Position;
            }
        }
        public void RenewRadius()
        {
            RadiusPolygon = CreateCircle(Position, 2.0f);
        }
        private GMapPolygon CreateCircle(PointLatLng point, float stroke)
        {
            double circleCurve = 0.25;
            List<PointLatLng> gpollist = new List<PointLatLng>();
            for (int i = 0; i < 360 * circleCurve; i++)
            {
                gpollist.Add(MainForm.FindPointAtDistance(point, i / circleCurve, Radar.Radius));
            }
            GMapPolygon gpol = new GMapPolygon(gpollist, "circle");
            gpol.Fill = new SolidBrush(Color.Transparent);
            gpol.Stroke = new Pen(Color.CornflowerBlue, stroke);
            gpol.IsHitTestVisible = true;
            return gpol;
        }
        private Brush LabelColor
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
        private Image RadarImage
        {
            get => _Image;
        }
        public override void OnRender(Graphics g)
        {
            Font _font = new Font("Angsana New", 14, FontStyle.Bold);
            var stringSize = g.MeasureString(Radar.Name, _font);
            var localPoint = new PointF((LocalPosition.X + 20) - (stringSize.Width / 2), (LocalPosition.Y - 5) + (stringSize.Height / 2));
            g.DrawString(Radar.Name, _font, LabelColor, localPoint);

            Matrix temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
            g.RotateTransform(-Overlay.Control.Bearing);
            g.DrawImageUnscaled(RadarImage, RadarImage.Width / -2, RadarImage.Height / -2);
            g.Transform = temp;
        }
        public override void Dispose()
        {
            if (_Image != null) _Image.Dispose();
            base.Dispose();
        }
    }
}
