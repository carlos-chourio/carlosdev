using Microsoft.Extensions.DependencyInjection;
using Carlosdev.Application.Posts.Commands.CreatePost;
using Carlosdev.Application.Posts.Queries;
using Carlosdev.Application.Interfaces.Persistence;
using Carlosdev.Persistence.Posts;
using Carlosdev.Persistence.Comments;
using Carlosdev.Application.Posts.Commands.CreatePost.Factory;
using Carlosdev.Common.Dates;

namespace Carlosdev.Common.IoC {
    public static class ServiceCollectionExtensions {
        public static IServiceCollection AddCommandsAndQueries(this IServiceCollection services) {
            return services.AddTransient<ICreatePostCommand, CreatePostCommand>()
                           .AddTransient<IGetPostQuery, GetPostQuery>()
                           .AddTransient<PostFactory>()
                           .AddTransient<IDateService, DateService>();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            return services.AddTransient<IPostRepository, PostRepository>()
                           .AddTransient<ICommentRepository, CommentRepository>();
        }
    }
}
