using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TODO.Domain;
using TODO.Domain.Concrete;
using TODO.Domain.Interfaces;

namespace Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly IDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(IDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public IList<TEntity> GetList()
        {
            return _dbSet.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(object id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
