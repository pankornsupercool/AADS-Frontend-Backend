using GMap.NET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AADS.Models
{
    public class CityData
    {
        [JsonIgnore]

        public PointLatLng Position { get; set; }
        public String Name { get; set; }
        public String Label { get; set; }
        public String Remark { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
