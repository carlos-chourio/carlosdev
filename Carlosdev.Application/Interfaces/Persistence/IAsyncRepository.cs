using Carlosdev.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Carlosdev.Application.Interfaces.Persistence {
    public interface IAsyncRepository<TEntity> : IAsyncUnitOfWork where TEntity : IEntity {
        Task Add(TEntity entity);
        Task Remove(int id);
        Task<TEntity> Get(int id);
        Task<IQueryable<TEntity>> GetAll();
        Task Update(TEntity entity);
    }
}
