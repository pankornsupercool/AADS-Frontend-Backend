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

namespace AADS
{
    public enum TrackStatus
    {
        OverridePending = -1,
        Pending = 0,
        Unknown = 1,
        Friendly = 2,
        Hostile = 3
    }
    public class TrackStatuses
    {
        public static IEnumerable<TrackStatus> Values
        {
            get
            {
                yield return TrackStatus.Pending;
                yield return TrackStatus.Unknown;
                yield return TrackStatus.Friendly;
                yield return TrackStatus.Hostile;
            }
        }
    }
    public class TrackData
    {
        [JsonIgnore]
        public string Key
        {
            get
            {
                return "AADS" + Number.ToString("000") + "X";
            }
        }
        public string CallSign { get; set; }
        public TrackStatus Status { get; set; }
        public bool Faker { get; set; }
        public int Number { get; set; }
        public PointLatLng Position { get; set; }
        public double Speed { get; set; }
        public double Bearing { get; set; }
        public double? Height { get; set; }
        public DateTime LastUpdated { get; set; }
        public void Copy(TrackData track)
        {
            this.CallSign = track.CallSign;
            this.Status = track.Status;
            this.Faker = track.Faker;
            this.Number = track.Number;
            this.Position = track.Position;
            this.Speed = track.Speed;
            this.Bearing = track.Bearing;
            this.Height = track.Height;
            this.LastUpdated = track.LastUpdated;
        }
    }
}
