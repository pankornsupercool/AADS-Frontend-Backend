using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    public class CartesianCoordinate
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public int Round { get; set; }
        public CartesianCoordinate(Coordinate coordinate)
        {
            X = Math.Cos(coordinate.Longitude * Math.PI / 180) * Math.Cos(coordinate.Latitude * Math.PI / 180);
            Y = Math.Sin(coordinate.Longitude * Math.PI / 180) * Math.Cos(coordinate.Latitude * Math.PI / 180);
            Z = Math.Sin(coordinate.Latitude * Math.PI / 180);
            Round = coordinate.Round;
        }
        public double Latitude
        {
            get
            {
                double hyp = Math.Sqrt(X * X + Y * Y);
                double lat = Math.Atan2(Z, hyp);
                return lat * (180 / Math.PI);
            }
        }
        public double Longitude
        {
            get
            {
                double lng = Math.Atan2(Y, X);
                return lng * (180 / Math.PI);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Math.Round(X, Round) + " ");
            sb.Append(Math.Round(Y, Round) + " ");
            sb.Append(Math.Round(Z, Round));
            return sb.ToString();
        }
    }
}
