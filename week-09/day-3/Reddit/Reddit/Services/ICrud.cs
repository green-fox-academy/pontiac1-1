using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public interface ICrud<T>
    {
        T Create(T TtoCreate);
        List<T> Read();
        void Update(T TtoUpdate);
        string Delete(string todelete);
    }
}
