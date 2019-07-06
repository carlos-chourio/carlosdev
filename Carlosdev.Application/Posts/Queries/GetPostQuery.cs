using System.Linq;
using Carlosdev.Application.Interfaces.Persistence;
using Carlosdev.Domain.Posts;

namespace Carlosdev.Application.Posts.Queries {
    public class GetPostQuery : IGetPostQuery {
        private readonly IPostRepository postRepository;

        public GetPostQuery(IPostRepository postRepository) {
            this.postRepository = postRepository;
        }
        public IQueryable<Post> Execute() {
            return postRepository.GetAll();
        }
    }
}
