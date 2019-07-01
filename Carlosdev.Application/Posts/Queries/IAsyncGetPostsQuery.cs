using Carlosdev.Domain.Posts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carlosdev.Application.Posts.Queries {
    interface IAsyncGetPostsQuery {
        Task<IEnumerable<Post>> IAsyncGetAllPosts();
    }
}
