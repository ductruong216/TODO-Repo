using System.Collections.Generic;

namespace TODO.Domain
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IList<TEntity> GetList();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        TEntity GetByID(object id);
    }
}
