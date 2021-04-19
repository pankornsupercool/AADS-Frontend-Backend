using CoordinateSharp;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AADS
{
    public class PositionConverter
    {
        public static string DefaultScale = "Signed Degree";
        public static PointLatLng ParsePointFromString(string pos)
        {
            PointLatLng point = new PointLatLng();
            CoordinateSharp.Coordinate c;
            if (CoordinateSharp.Coordinate.TryParse(pos, out c))
            {
                point.Lat = c.Latitude.ToDouble();
                point.Lng = c.Longitude.ToDouble();
            }
            else
            {
                GeorefCoordinate georef;
                if (GeorefCoordinate.TryParse(pos, out georef)) {
                    point.Lat = georef.Latitude;
                    point.Lng = georef.Longitude;
                }
                else
                {
                    try
                    {
                        string[] arr = pos.Split(',');
                        point.Lat = Convert.ToDouble(arr[0]);
                        point.Lng = Convert.ToDouble(arr[1]);
                    }
                    catch (Exception)
                    {
                        point = new PointLatLng();
                    }
                }
            }
            return point;
        }
        public static string georef;
        public static string ParsePointToString(PointLatLng point, string scale)
        {
            CoordinateSharp.Coordinate c = new CoordinateSharp.Coordinate(point.Lat, point.Lng);
            Coordinate coordinate = new Coordinate(point.Lat, point.Lng);
            if (scale == "Signed Degree")
            {
                coordinate.Round = 7;
                return coordinate.SignedDegree;
            }
            else if (scale == "Decimal Degree" || scale == "Lat/Lon d°")
            {
                coordinate.Round = 3;
                return coordinate.DecimalDegree;
            }
            else if (scale == "Degree Decimal Minutes")
            {
                coordinate.Round = 3;
                return coordinate.DegreeDecimalMinutes;
            }
            else if (scale == "Degree Minute Seconds" || scale == "Lat/Lon dms")
            {
                coordinate.Round = 3;
                return coordinate.DegreeMinuteSeconds;
            }
            else if (scale == "UTM")
            {
                return c.UTM.ToString();
            }
            else if (scale == "MGRS")
            {
                return c.MGRS.ToString();
            }
            else if (scale == "Cartesian")
            {
                coordinate.Round = 3;
                return coordinate.Cartesian.ToString();
            }
            else if (scale == "ECEF")
            {
                return c.ECEF.ToString();
            }
            else if (scale == "GEOREF")
            {
                coordinate.GeorefPrecision = 2;
                return coordinate.GEOREF.ToString();
            }
            return null;
        }
    }
}
