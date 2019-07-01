using Carlosdev.Domain.Posts;
using System.Collections.Generic;

namespace Carlosdev.Application.Posts.Queries {
    public interface IGetPostsQuery {
        IEnumerable<Post> GetAllPosts();
    }
}
