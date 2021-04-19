using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AADS
{
    public class GeorefCoordinate
    {
        private static string georefFirstLngLetter = "ABCDEFGHJKLMNPQRSTUVWXYZ";
        private static string georefFirstLatLetter = "ABCDEFGHJKLM";
        private static string georefSecondLetter = "ABCDEFGHJKLMNPQ";
        private static int georefMinute(double min)
        {
            if (min < 0) min += 60;
            return (int)min;
        }
        private static int georefSecond(double sec, int prec)
        {
            int modifier = (int)Math.Pow(10, prec);
            sec = Math.Round(sec, prec) / 60 * modifier;
            if (sec < 0)
            {
                sec += modifier;
            }
            return (int)sec;
        }
        public static bool TryParse(string georef, out GeorefCoordinate coordinate)
        {
            Regex regex = new Regex(@"([ABCDEFGHJKLMNPQRSTUVWXYZ]{1})([ABCDEFGHJKLM]{1})([ABCDEFGHJKLMNPQ]{2})(\d+)");
            Match match = regex.Match(georef);
            if (match.Success)
            {
                coordinate = new GeorefCoordinate(georef);
                return true;
            }
            else
            {
                coordinate = null;
                return false;
            }
        }
        public string GlobalZone { get; set; }
        public string LocalZone { get; set; }
        public string LatitudeZone { get; set; }
        public string LongitudeZone { get; set; }
        public int Precision { get; private set; }
        public GeorefCoordinate(Coordinate coordinate, int precision)
        {
            Precision = precision;
            string format = new string('0', precision);
            int lngFirsti = (int)((coordinate.Longitude + 180) / 15);
            int latFirsti = (int)((coordinate.Latitude + 90) / 15);
            int lngSecondi = (int)((coordinate.Longitude + 180) % 15);
            int latSecondi = (int)((coordinate.Latitude + 90) % 15);
            GlobalZone = georefFirstLngLetter[lngFirsti].ToString() + georefFirstLatLetter[latFirsti].ToString();
            LocalZone = georefSecondLetter[lngSecondi].ToString() + georefSecondLetter[latSecondi].ToString();
            LatitudeZone = georefMinute(coordinate.LatitudeDecimalMinute).ToString("00");
            LongitudeZone = georefMinute(coordinate.LongitudeDecimalMinute).ToString("00");
            if (precision > 0)
            {
                LatitudeZone += georefSecond(coordinate.LatitudeSecond, precision).ToString(format);
                LongitudeZone += georefSecond(coordinate.LongtitudeSecond, precision).ToString(format);
            }
        }
        private GeorefCoordinate(string georef)
        {
            Regex regex = new Regex(@"([ABCDEFGHJKLMNPQRSTUVWXYZ]{1})([ABCDEFGHJKLM]{1})([ABCDEFGHJKLMNPQ]{2})(\d+)");
            Match match = regex.Match(georef);
            if (match.Success)
            {
                GlobalZone = match.Groups[1].Value + match.Groups[2].Value;
                LocalZone = match.Groups[3].Value;
                string latlngzone = match.Groups[4].Value;
                Precision = latlngzone.Length / 2 - 2;
                LatitudeZone = latlngzone.Substring(Precision + 2);
                LongitudeZone = latlngzone.Substring(0, Precision + 2);
            }
        }
        public double Latitude
        {
            get
            {
                int latdeg = georefFirstLatLetter.IndexOf(GlobalZone[1]) * 15 - 90 + georefSecondLetter.IndexOf(LocalZone[1]);
                int latmin = int.Parse(LatitudeZone.Substring(0, 2));
                double latsec = 0;
                if (Precision > 0)
                {
                    var modifier = Math.Pow(10, Precision);
                    latsec = double.Parse(LatitudeZone.Substring(2)) * 60 / modifier;
                }
                return latdeg + (latmin / 60.0) + (latsec / 3600);
            }
        }
        public double Longitude
        {
            get
            {
                int lngdeg = georefFirstLngLetter.IndexOf(GlobalZone[0]) * 15 - 180 + georefSecondLetter.IndexOf(LocalZone[0]);
                int lngmin = int.Parse(LongitudeZone.Substring(0, 2));
                double lngsec = 0;
                if (Precision > 0)
                {
                    var modifier = Math.Pow(10, Precision);
                    lngsec = double.Parse(LongitudeZone.Substring(2)) * 60 / modifier;
                }
                return lngdeg + (lngmin / 60.0) + (lngsec / 3600);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GlobalZone);
            sb.Append(LocalZone);
            sb.Append(LongitudeZone);
            sb.Append(LatitudeZone);
            return sb.ToString();
        }
    }
}
