using Carlosdev.Domain.Posts;
using System.Linq;

namespace Carlosdev.Application.Posts.Queries {
    public interface IGetPostQuery {
        IQueryable<Post> Execute();
    }
}
