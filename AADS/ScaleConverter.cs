using System;
using System.Collections.Generic;
using System.Text;

namespace AADS
{
    public class ScaleConverter
    {
        public static double ConvertHeight(double value, string scale, string returnedScale)
        {
            double ft = value;
            //convert to feet
            if (scale == "m")
            {
                ft = value * 3.28084;
            }
            else if (scale == "kft")
            {
                ft = value * 1000;
            }
            else if (scale == "km")
            {
                ft = value * 3280.84;
            }
            else if (scale == "FL")
            {
                ft = value * 100;
            }
            else if (scale == "nmi")
            {
                ft = value * 0.0001645788337;
            }
            //convert to expected scale
            if (returnedScale == "ft")
            {
                return ft;
            }
            else if (returnedScale == "m")
            {
                return ft / 3.28084;
            }
            else if (returnedScale == "kft")
            {
                return ft / 1000;
            }
            else if (returnedScale == "km")
            {
                return ft / 3280.84;
            }
            else if (returnedScale == "FL")
            {
                return ft / 100;
            }
            else if (returnedScale == "nmi")
            {
                return ft / 0.0001645788337;
            }
            return 0;
        }
        public static double ConvertSpeed(double value, string scale, string returnedScale)
        {
            double kmph = value;
            //convert to kmph
            if (scale == "mps")
            {
                kmph = value * 3.6;
            }
            else if (scale == "knots")
            {
                kmph = value / 0.539956803;
            }
            else if (scale == "mph")
            {
                kmph = value / 0.621371192;
            }
            //convert to expected scale
            if (returnedScale == "m/s")
            {
                return kmph / 3.6;
            }
            else if (returnedScale == "kmph")
            {
                return kmph;
            }
            else if (returnedScale == "knots")
            {
                return kmph * 0.539956803;
            }
            else if (returnedScale == "mph")
            {
                return kmph * 0.621371192;
            }
            return 0;
        }
        public static double ConvertBearing(double value, string scale, string returnedScale)
        {
            double deg = value;
            const double degToMilFactor = 0.05625;
            const double degToRadFactor = Math.PI / 180;
            //convert to degree
            if (scale == "radian")
            {
                deg = value / degToRadFactor;
            }
            else if (scale == "mil")
            {
                deg = value * degToMilFactor;
            }
            //convert to expected scale
            if (returnedScale == "radian")
            {
                return deg * degToRadFactor;
            }
            else if (returnedScale == "mil")
            {
                return deg / degToMilFactor;
            }
            else if (returnedScale == "degree")
            {
                return deg;
            }
            return 0;
        }
    }
}
