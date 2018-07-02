using Repository;
using System.Collections.Generic;
using System.Windows.Forms;
using TODO.Domain;
using TODO.Domain.Interfaces;

namespace Service
{
    public class BaseService<TEntity, TContext> : IBaseService<TEntity>
        where TEntity : class
        where TContext : IDbContext, new()
    {
        protected readonly IGenericRepository<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseService()
        {
            _unitOfWork = new UnitOfWork<TContext>();
            _repository = _unitOfWork.Repository<TEntity>();
        }
        public void Add(TEntity entity)
        {
            try
            {
                _repository.Add(entity);
                _unitOfWork.Save();
            }
            catch
            {
                throw;
            }
        }

        public void Delete(object id)
        {
            try
            {
                _repository.Delete(id);
                _unitOfWork.Save();
            }
            catch
            {
                throw;
            }
        }

        public TEntity GetByID(object id)
        {
            var entity = _repository.GetByID(id);
            return entity;
        }

        public IList<TEntity> GetList()
        {
            return _repository.GetList();
        }

        public void Update(TEntity entity)
        {
            try
            {
                _repository.Update(entity);
                _unitOfWork.Save();
            }
            catch
            {
                throw;
            }
        }
    }
}