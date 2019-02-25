using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batis
{
    public interface IAppservice<T>:IDisposable
    {
        void Insert(T model);
        void Update(T model);
        void Delete(object id);
        T Get(object where);
        IList<T> GetAll(object where);
    }
}
