using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batis
{
    public abstract class BaseAppService<T> : IAppservice<T>
    {
        public ISqlMapper Map;
        public BaseAppService()
        {
            DomSqlMapBuilder builder = new DomSqlMapBuilder();
            Map = builder.Configure();
        }

        public virtual void Delete(object id)
        {
            Map.Delete("Delete", id);
        }

        public void Dispose()
        {
            Map = null;
        }

        public virtual T Get(object where)
        {

            return Map.QueryForObject<T>("Select", where);
        }

        public virtual IList<T> GetAll(object where)
        {
            Map.QueryForObject()
            return Map.QueryForList<T>("Select_all", where);
        }

        public virtual void Insert(T model)
        {
            Map.Insert("Insert", model);
        }

        public virtual void Update(T model)
        {
            Map.Update("Update", model);
        }
    }
}
