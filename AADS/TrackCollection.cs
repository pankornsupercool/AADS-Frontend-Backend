using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AADS
{
    public class TrackCollection : IDataCollection<TrackData>
    {
        public delegate void TrackCollectionClear();
        public delegate void TrackCollectionAdd(TrackData data);
        public delegate void TrackCollectionUpdate(TrackData data);
        public delegate void TrackCollectionRemove(TrackData data);
        public event TrackCollectionAdd OnCollectionAdd;
        public event TrackCollectionUpdate OnCollectionUpdate;
        public event TrackCollectionRemove OnCollectionRemove;
        private Dictionary<string, TrackData> _Tracks = new Dictionary<string, TrackData>();
        [JsonIgnore]
        public bool PerformAction { get; set; }
        public List<TrackData> Tracks { get; set; }
        public TrackCollection()
        {
            this.PerformAction = false;
            this.Tracks = new List<TrackData>();
            OnCollectionAdd += TrackCollection_OnCollectionAdd;
            OnCollectionUpdate += TrackCollection_OnCollectionUpdate;
            OnCollectionRemove += TrackCollection_OnCollectionRemove;
        }
        public TrackCollection(List<TrackData> tracks) : this()
        {
            if (tracks != null) tracks.ForEach(x => Add(x));
        }
        private void Categorize(TrackData track, bool delete)
        {
            if (delete)
            {
                Tracks.Remove(track);
            }
            else
            {
                Tracks.Add(track);
            }
        }
        private void TrackCollection_OnCollectionAdd(TrackData data)
        {
            Categorize(data, false);
        }

        private void TrackCollection_OnCollectionUpdate(TrackData data)
        {
        }

        private void TrackCollection_OnCollectionRemove(TrackData data)
        {
            Categorize(data, true);
        }
        public bool ContainsKey(string key)
        {
            return _Tracks.ContainsKey(key);
        }
        public void Clear()
        {
            _Tracks.Clear();
            Tracks.Clear();
        }
        public IEnumerable<string> Keys
        {
            get => new List<string>(_Tracks.Keys);
        }
        public TrackData this[string key]
        {
            get
            {
                if (_Tracks.ContainsKey(key))
                {
                    return _Tracks[key];
                }
                return null;
            }
        }
        public bool Add(TrackData data)
        {
            var key = data.Key;
            if (!_Tracks.ContainsKey(key))
            {
                _Tracks.Add(key, data);
                OnCollectionAdd?.Invoke(data);
                return true;
            }
            return false;
        }
        public TrackData Update(TrackData data)
        {
            var key = data.Key;
            if (_Tracks.ContainsKey(key))
            {
                var track = _Tracks[key];
                track.Copy(data);
                OnCollectionUpdate?.Invoke(track);
                return track;
            }
            return null;
        }
        public TrackData Remove(string key)
        {
            if (_Tracks.ContainsKey(key))
            {
                var track = _Tracks[key];
                _Tracks.Remove(key);
                OnCollectionRemove?.Invoke(track);
                return track;
            }
            return null;
        }
        public void ForEach(Action<TrackData> action)
        {
            foreach (var key in _Tracks.Keys)
            {
                var track = _Tracks[key];
                action(track);
            }
        }
    }
}
