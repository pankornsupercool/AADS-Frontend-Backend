using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    public interface IDataManager<T>
    {
        void Clear();
        T Get(string key);
        CommandResponse Create(T data);
        CommandResponse Update(T data);
        CommandResponse Remove(string key);
    }
}
