using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    public enum RadarSiteType
    {
        TRML, DR172ADV
    }
    public class RadarSite
    {
        public string Name { get; set; }
        public RadarSiteType Type { get; set; }
        public PointLatLng Position { get; set; }
        public double Radius { get; set; }

        public PointLatLng GetPosition(double PositionX, double PositionY)
        {
            var lat = Position.Lat + PositionY;
            var lng = Position.Lng + PositionX;
            return new PointLatLng(lat, lng);
        }
    }
}
