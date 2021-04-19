using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AADS
{
    public delegate void RadarClear();
    public delegate void RadarCreate(RadarSite radar);
    public delegate void RadarUpdate(RadarSite radar);
    public delegate void RadarRemove(RadarSite radar);
    public class RadarManager : IDataManager<RadarSite>
    {
        private Dictionary<string, RadarSite> radars = new Dictionary<string, RadarSite>();
        public event RadarClear OnRadarClear;
        public event RadarCreate OnRadarCreate;
        public event RadarUpdate OnRadarUpdate;
        public event RadarRemove OnRadarRemove;
        public void Clear()
        {
            OnRadarClear?.Invoke();
            radars.Clear();
        }
        public List<RadarSite> Radars
        {
            get => new List<RadarSite>(radars.Values);
        }
        public RadarSite Get(string name)
        {
            if (radars.ContainsKey(name))
            {
                return radars[name];
            }
            return null;
        }
        public CommandResponse Create(RadarSite radar)
        {
            var name = radar.Name;
            CommandResponse response = new CommandResponse
            {
                Code = CommandResponseCode.Error
            };
            if (radars.ContainsKey(name))
            {
                response.Message = "DUPLICATE_KEY";
            }
            else
            {
                radars.Add(name, radar);
                OnRadarCreate?.Invoke(radar);
                response.Code = CommandResponseCode.Success;
            }
            return response;
        }
        public CommandResponse Update(RadarSite radar)
        {
            var name = radar.Name;
            CommandResponse response = new CommandResponse
            {
                Code = CommandResponseCode.Error
            };
            if (radars.ContainsKey(name))
            {
                radars[name] = radar;
                OnRadarUpdate?.Invoke(radar);
                response.Code = CommandResponseCode.Success;
            }
            else
            {
                response.Message = "KEY_NOT_FOUND";
            }
            return response;
        }
        public CommandResponse Remove(string name)
        {
            CommandResponse response = new CommandResponse
            {
                Code = CommandResponseCode.Error
            };
            if (radars.ContainsKey(name))
            {
                var radar = radars[name];
                radars.Remove(name);
                OnRadarRemove?.Invoke(radar);
                response.Code = CommandResponseCode.Success;
            }
            else
            {
                response.Message = "KEY_NOT_FOUND";
            }
            return response;
        }
    }
}
