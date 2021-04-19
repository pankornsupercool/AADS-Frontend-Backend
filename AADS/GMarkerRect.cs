using System.Drawing;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using System;
using System.Runtime.Serialization;
using System.Drawing.Drawing2D;

namespace AADS
{
    public class GMarkerRect : GMapMarker
    {
        public static bool EnableHitbox = false;
        public GMapMarker InnerMarker;
        public GMarkerRect(GMarkerRadar marker) : base(marker.Position)
        {
            IsHitTestVisible = true;
            InnerMarker = marker;
            Size = new Size(30, 30);
            Offset = new Point(-Size.Width / 2, -Size.Height / 2);
        }
        public GMarkerRect(GMarkerTrack marker) : base(marker.Position)
        {
            IsHitTestVisible = true;
            InnerMarker = marker;
            Size = new Size(30, 30);
            Offset = new Point(-Size.Width / 2, -Size.Height / 2);
        }
        public GMarkerRect(GMarker marker) : base(marker.Position)
        {
            IsHitTestVisible = true;
            InnerMarker = marker;
            Size = new Size(30, 30);
            Offset = new Point(-Size.Width / 2, -Size.Height / 2 - GMarker.ImageSize.Height / 2);
        }
        public void SetPosition(PointLatLng point)
        {
            Position = point;
            InnerMarker.Position = point;
        }
        public override void OnRender(Graphics g)
        {
            Pen pen = new Pen(EnableHitbox ? Color.Black : Color.Empty, 2);
            g.DrawRectangle(pen, new Rectangle(LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height));
        }

        public override void Dispose()
        {
            if (InnerMarker != null)
            {
                InnerMarker.Dispose();
                InnerMarker = null;
            }

            base.Dispose();
        }
    }
}
