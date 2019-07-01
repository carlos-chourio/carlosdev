using Carlosdev.Domain.Posts;
using System.Threading.Tasks;

namespace Carlosdev.Application.Interfaces {
    public interface IAsyncPostService : IAsyncUnitOfWork {
        void CreatePost(Post post);
        Task<Post> GetPost(int id);
        void DeletePost(int id);
    }
}
