using System;
using System.Linq;
using System.Linq.Expressions;
using Carlosdev.Application.Interfaces.Persistence;
using Carlosdev.Domain.Posts;

namespace Carlosdev.Persistence.Posts {
    public class PostRepository : IPostRepository {
        private readonly CarlosdevContext context;

        public PostRepository(CarlosdevContext context) {
            this.context = context;
        }

        public void Add(Post entity) {
            context.Add(entity);
        }

        public Post Get(int id) {
            return context.Post.Find(id);
        }

        public IQueryable<Post> GetAll() {
            return context.Post.OrderBy(t => t.CreationDate);
        }
        public IQueryable<Post> GetByCondition(Expression<Func<Post, bool>> expression) {
            return context.Post.Where(expression);
        }

        public void Remove(Post post) {
            context.Post.Remove(post);
        }

        public bool SaveChanges() {
            return context.SaveChanges() > 0;
        }
    }
}
