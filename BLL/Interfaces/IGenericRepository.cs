using System.Collections.Generic;

namespace TODO.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IList<TEntity> GetList();
        TEntity GetByID(object id);
        void Add(TEntity task);
        void Delete(object id);
        void Update(TEntity task);
    }
}
