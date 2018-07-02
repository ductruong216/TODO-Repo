using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Linq;
using TODO.Domain;
using TODO.Domain.Interfaces;

namespace Repository
{
    public class UnitOfWork<TContext> : IUnitOfWork where TContext : IDbContext, new()
    {
        private readonly Dictionary<Type, object> _repositories;
        private readonly IDbContext _context;
        private DbTransaction _transaction;
        private ObjectContext _objectContext;

        public UnitOfWork()
        {
            _context = new TContext();
            _repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            // Checks if the Dictionary Key contains the Model class
            if (_repositories.Keys.Contains(typeof(TEntity)))
            {
                // Return the repository for that Model class
                return _repositories[typeof(TEntity)] as IGenericRepository<TEntity>;
            }

            // If the repository for that Model class doesn't exist, create it
            var repository = new GenericRepository<TEntity>(_context);

            // Add it to the dictionary
            _repositories.Add(typeof(TEntity), repository);

            return repository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void BeginTransaction()
        {
            //_objectContext = ((IObjectContextAdapter)DataContext.Context).ObjectContext;
            //if (_objectContext.Connection.State != ConnectionState.Open)
            //{
            //    _objectContext.Connection.Open();
            //}
            //_transaction = _objectContext.Connection.BeginTransaction();
        }

        public bool Commit()
        {
            _context.SaveChanges();
            if (_transaction != null)
            {
                _transaction.Commit();
            }

            return true;
        }

        public void Rollback()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
            }
        }
    }
}