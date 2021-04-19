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
    public class GMarker : GMapMarker
    {
        public static Size ImageSize = new Size(30, 30);
        private string _Name;
        private Image _Image;
        private readonly GMapControl map = ControlViews.Main.gMap;

        public GMarker(PointLatLng point, string name, Image image) : base(point)
        {
            _Name = name;
            _Image = new Bitmap(image, ImageSize);
        }
        public Brush LabelColor
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
        public string Name
        {
            get => _Name;
        }
        public Image Image
        {
            get => _Image;
        }
        public override void OnRender(Graphics g)
        {
            Font _font = new Font("Angsana New", 14, FontStyle.Bold);
            var stringSize = g.MeasureString(Name, _font);
            var localPoint = new PointF((LocalPosition.X + 25) - (stringSize.Width / 2), (LocalPosition.Y - 20) + (stringSize.Height / 2));
            g.DrawString(Name, _font, LabelColor, localPoint);

            Matrix temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y - ImageSize.Height / 2);
            g.RotateTransform(-Overlay.Control.Bearing);
            g.DrawImageUnscaled(Image, Image.Width / -2, Image.Height / -2);
            g.Transform = temp;
        }
        public override void Dispose()
        {
            if (_Image != null) _Image.Dispose();
            base.Dispose();
        }
    }
}
