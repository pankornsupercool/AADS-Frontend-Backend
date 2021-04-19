using GMap.NET.MapProviders;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    public class MapModeZoom
    {
        public int Default { get; set; }
        public int MinZoom { get; set; }
        public int MaxZoom { get; set; }
    }
    public class MapMode
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public GMapProvider MapProvider
        {
            get => GMapProviders.TryGetProvider(Type);
        }
        
        public MapModeZoom MiniMap { get; set; }
        public MapModeZoom MainMap { get; set; }
    }
}
