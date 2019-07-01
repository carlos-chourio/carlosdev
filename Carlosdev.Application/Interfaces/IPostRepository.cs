using Carlosdev.Domain.Posts;

namespace Carlosdev.Application.Interfaces {
    interface IPostService : IUnitOfWork {
        void CreatePost(Post post);
        Post GetPost(int id);
        void DeletePost(int id);
    }
}
