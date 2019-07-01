using System.Threading.Tasks;

namespace Carlosdev.Application.Interfaces {
    public interface IAsyncUnitOfWork {
        Task<bool> SaveChangesAsync();
    }
}
