using Carlosdev.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Carlosdev.Application.Interfaces.Persistence {
    public interface IAsyncRepository<TEntity> : IAsyncUnitOfWork where TEntity : IEntity {
        Task Add(TEntity entity);
        Task Remove(int id);
        Task<TEntity> GetAsync(int id);
        Task<IQueryable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity entity);
    }
}
