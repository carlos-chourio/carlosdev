using Carlosdev.Domain.Categories;
using Carlosdev.Domain.Comments;
using Carlosdev.Domain.Posts;
using Carlosdev.Domain.Tags;
using Microsoft.EntityFrameworkCore;

namespace Carlosdev.Persistence {
    public class CarlosdevContext : DbContext {
        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public CarlosdevContext(DbContextOptions options) : base(options) {
        }
    }
}
