using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AADS
{
    public class Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Round { get; set; }
        public int GeorefPrecision { get; set; }
        public Coordinate(double Latitude, double Longitude)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Round = 4;
            this.GeorefPrecision = 2;
        }
        
        public int LatitudeDegree
        {
            get => (int)Latitude;
        }
        public int LongitudeDegree
        {
            get => (int)Longitude;
        }
        public double LatitudeDecimalMinute
        {
            get => (Latitude - LatitudeDegree) * 60;
        }
        public int LatitudeMinute
        {
            get => (int)LatitudeDecimalMinute;
        }
        public double LongitudeDecimalMinute
        {
            get => (Longitude - LongitudeDegree) * 60;
        }
        public int LongitudeMinute
        {
            get => (int)LongitudeDecimalMinute;
        }
        public double LatitudeSecond
        {
            get => (Latitude - LatitudeDegree - LatitudeMinute / 60.0) * 3600;
        }
        public double LongtitudeSecond
        {
            get => (Longitude - LongitudeDegree - LongitudeMinute / 60.0) * 3600;
        }
        public string SignedDegree
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Math.Round(Latitude, Round) + " ");
                sb.Append(Math.Round(Longitude, Round));
                return sb.ToString();
            }
        }
        public string DecimalDegree
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                int modifier;
                if (LatitudeDegree >= 0)
                {
                    modifier = 1;
                    sb.Append("N ");
                }
                else
                {
                    modifier = -1;
                    sb.Append("S ");
                }
                sb.Append(Math.Round(Latitude * modifier, Round) + "º ");
                if (LongitudeDegree >= 0)
                {
                    modifier = 1;
                    sb.Append("E ");
                }
                else
                {
                    modifier = -1;
                    sb.Append("W ");
                }
                sb.Append(Math.Round(Longitude * modifier, Round) + "º");
                return sb.ToString();
            }
        }
        public string DegreeDecimalMinutes
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                int modifier;
                if (LatitudeDegree >= 0)
                {
                    modifier = 1;
                    sb.Append("N ");
                }
                else
                {
                    modifier = -1;
                    sb.Append("S ");
                }
                sb.Append((LatitudeDegree * modifier) + "º " + Math.Round(LatitudeDecimalMinute * modifier, Round) + "' ");
                if (LongitudeDegree >= 0)
                {
                    modifier = 1;
                    sb.Append("E ");
                }
                else
                {
                    modifier = -1;
                    sb.Append("W ");
                }
                sb.Append((LongitudeDegree * modifier) + "º " + Math.Round(LongitudeDecimalMinute * modifier, Round) + "'");
                return sb.ToString();
            }
        }
        public string DegreeMinuteSeconds
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                int modifier;
                if (LatitudeDegree >= 0)
                {
                    modifier = 1;
                    sb.Append("N ");
                }
                else
                {
                    modifier = -1;
                    sb.Append("S ");
                }
                sb.Append((LatitudeDegree * modifier) + "º " + (LatitudeMinute * modifier) + "' " + Math.Round(LatitudeSecond * modifier, Round) + "\" ");
                if (LongitudeDegree >= 0)
                {
                    modifier = 1;
                    sb.Append("E ");
                }
                else
                {
                    modifier = -1;
                    sb.Append("W ");
                }
                sb.Append((LongitudeDegree * modifier) + "º " + (LongitudeMinute * modifier) + "' " + Math.Round(LongtitudeSecond * modifier, Round) + "\"");
                return sb.ToString();
            }
        }
        public CartesianCoordinate Cartesian
        {
            get
            {
                CartesianCoordinate cartesian = new CartesianCoordinate(this);
                return cartesian;
            }
        }
        public GeorefCoordinate GEOREF
        {
            get
            {
                GeorefCoordinate georef = new GeorefCoordinate(this, GeorefPrecision);
                return georef;
            }
        }
        public override string ToString()
        {
            return SignedDegree;
        }
    }
}
