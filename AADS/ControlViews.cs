using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    public class ControlViews
    {
        public static MainForm Main = MainForm.GetInstance();
        // Main Category
        private Views.ShowCategory.Marker marker = new Views.ShowCategory.Marker();
        private Views.ShowCategory.Line line = new Views.ShowCategory.Line();
        private Views.ShowCategory.Polygon polygon = new Views.ShowCategory.Polygon();
        private Views.ShowCategory.Track track = new Views.ShowCategory.Track();
        // Marker
        private Views.Marker.AirportCreation airportCreation = new Views.Marker.AirportCreation();
        private Views.Marker.AirportView airportView = new Views.Marker.AirportView();
        private Views.Marker.CityCreation cityCreation = new Views.Marker.CityCreation();
        private Views.Marker.FireUnitCreation fireUnitCreation = new Views.Marker.FireUnitCreation();
        private Views.Marker.LandmarkCreation landmarkCreation = new Views.Marker.LandmarkCreation();
        private Views.Marker.LandmarkView landmarkView = new Views.Marker.LandmarkView();
        private Views.Marker.FixedPointCreation fixedPointCreation = new Views.Marker.FixedPointCreation();
        private Views.Marker.VitalAssetCreation vitalAssetCreation = new Views.Marker.VitalAssetCreation();
        private Views.Marker.VitalAssetView vitalAssetView = new Views.Marker.VitalAssetView();
        // Polygon
        private Views.Polygon.GeographicCreation geographicCreation = new Views.Polygon.GeographicCreation();
        // Track
        private Views.Track.TrackCreation trackCreation = new Views.Track.TrackCreation();
        private Views.Track.TrackView trackView = new Views.Track.TrackView();
        private static ControlViews _Instance;
        public static ControlViews Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ControlViews();
                }
                return _Instance;
            }
        }
        // Main
        public static Views.ShowCategory.Marker Marker {
            get => Instance.marker;
        }
        public static Views.ShowCategory.Line Line
        {
            get => Instance.line;
        }
        public static Views.ShowCategory.Polygon Polygon
        {
            get => Instance.polygon;
        }
        public static Views.ShowCategory.Track Track
        {
            get => Instance.track;
        }
        // Marker
        public static Views.Marker.AirportCreation AirportCreation
        {
            get => Instance.airportCreation;
        }
        public static Views.Marker.AirportView AirportView
        {
            get => Instance.airportView;
        }
        public static Views.Marker.CityCreation CityCreation
        {
            get => Instance.cityCreation;
        }
        public static Views.Marker.FireUnitCreation FireUnitCreation
        {
            get => Instance.fireUnitCreation;
        }
        public static Views.Marker.LandmarkCreation LandmarkCreation
        {
            get => Instance.landmarkCreation;
        }
        public static Views.Marker.LandmarkView LandmarkView
        {
            get => Instance.landmarkView;
        }
        public static Views.Marker.FixedPointCreation FixedPointCreation
        {
            get => Instance.fixedPointCreation;
        }
        public static Views.Marker.VitalAssetCreation VitalAssetCreation
        {
            get => Instance.vitalAssetCreation;
        }
        public static Views.Marker.VitalAssetView VitalAssetView
        {
            get => Instance.vitalAssetView;
        }
        // Polygon
        public static Views.Polygon.GeographicCreation GeographicCreation
        {
            get => Instance.geographicCreation;
        }
        // Track
        public static Views.Track.TrackCreation TrackCreation
        {
            get => Instance.trackCreation;
        }
        public static Views.Track.TrackView TrackView
        {
            get => Instance.trackView;
        }
        public ControlViews()
        {
            // Marker
            Main.gMap.MouseClick += vitalAssetCreation.GMap_MouseClick;
            Main.gMap.MouseClick += cityCreation.GMap_MouseClick;
            Main.gMap.MouseClick += fireUnitCreation.GMap_MouseClick;
            Main.gMap.MouseClick += fixedPointCreation.GMap_MouseClick;
            Main.gMap.MouseClick += landmarkCreation.GMap_MouseClick;
            Main.gMap.MouseClick += airportCreation.GMap_MouseClick;
            // Track
            Main.gMap.MouseClick += trackCreation.GMap_MouseClick;
        }
    }
}
