using System;

namespace TODO.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;

        void Dispose(bool disposing);

        void Save();

        void BeginTransaction();

        bool Commit();

        void Rollback();
    }
}