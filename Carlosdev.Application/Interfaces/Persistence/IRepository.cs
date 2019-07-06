using System;
using System.Linq;
using System.Linq.Expressions;

namespace Carlosdev.Application.Interfaces.Persistence {
    public interface IRepository<TEntity> : IUnitOfWork {
        void Add(TEntity entity);
        void Remove(TEntity entity);
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression);
    }
}
