using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AADS
{
    public delegate void TrackClear();
    public delegate void TrackCreate(TrackData item);
    public delegate void TrackUpdate(TrackData item);
    public delegate void TrackRemove(TrackData item);
    public class TrackManager : IDataManager<TrackData>
    {
        private TrackCollection collection = new TrackCollection();
        public event TrackClear OnTrackClear;
        public event TrackCreate OnTrackCreate;
        public event TrackUpdate OnTrackUpdate;
        public event TrackRemove OnTrackRemove;
        public TrackManager()
        {
            collection.PerformAction = true;
        }
        public void Clear()
        {
            OnTrackClear?.Invoke();
            collection.Clear();
        }
        public List<TrackData> Tracks
        {
            get => collection.Tracks;
        }
        public TrackData Get(string key)
        {
            return collection[key];
        }
        public void AddCollection(TrackCollection collection)
        {
            collection.Tracks.ForEach(x => Create(x));
        }
        public void UpdateCollection(TrackCollection collection)
        {
            collection.Tracks.ForEach(x => Update(x));
        }
        public void RemoveCollection(TrackCollection collection)
        {
            collection.Tracks.ForEach(x => Remove(x.Key));
        }
        public CommandResponse Create(TrackData track)
        {
            CommandResponse response = new CommandResponse
            {
                Code = CommandResponseCode.Error
            };
            if (collection.Add(track))
            {
                response.Code = CommandResponseCode.Success;
                OnTrackCreate?.Invoke(track);
            }
            else
            {
                response.Message = "DUPLICATE_KEY";
            }
            return response;
        }
        public CommandResponse Update(TrackData track)
        {
            CommandResponse response = new CommandResponse
            {
                Code = CommandResponseCode.Error
            };
            TrackData _track = collection.Update(track);
            if (_track != null)
            {
                response.Code = CommandResponseCode.Success;
                OnTrackUpdate?.Invoke(_track);
            }
            else
            {
                response.Message = "KEY_NOT_FOUND";
            }
            return response;
        }
        public CommandResponse Remove(string key)
        {
            CommandResponse response = new CommandResponse
            {
                Code = CommandResponseCode.Error
            };
            TrackData track = collection.Remove(key);
            if (track != null)
            {
                response.Code = CommandResponseCode.Success;
                OnTrackRemove?.Invoke(track);
            }
            else
            {
                response.Message = "KEY_NOT_FOUND";
            }
            return response;
        }
    }
}
