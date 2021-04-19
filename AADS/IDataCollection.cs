using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AADS
{
    public interface IDataCollection<T>
    {
        bool PerformAction { get; set; }
        IEnumerable<string> Keys { get; }
        T this[string key] { get; }
        bool ContainsKey(string key);
        void Clear();
        bool Add(T data);
        T Update(T data);
        T Remove(string key);
        void ForEach(Action<T> action);
    }
}
