using Carlosdev.Application.Interfaces.Persistence;
using Carlosdev.Domain.Comments;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Carlosdev.Persistence.Comments {
    public class CommentRepository : ICommentRepository {
        private readonly CarlosdevContext context;

        public CommentRepository(CarlosdevContext context) {
            this.context = context;
        }
        public void Add(Comment entity) {
            context.Add(entity);
        }

        public Comment Get(int id) {
            return context.Comment.Find(id);
        }

        public IQueryable<Comment> GetAll() {
            return context.Comment;
        }

        public IQueryable<Comment> GetByCondition(Expression<Func<Comment, bool>> expression) {
            return context.Comment.Where(expression);
        }

        public void Remove(Comment comment) {
            context.Comment.Remove(comment);
        }

        public bool SaveChanges() {
            return context.SaveChanges() > 0;
        }

    }
}
