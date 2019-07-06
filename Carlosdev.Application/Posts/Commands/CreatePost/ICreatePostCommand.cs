using Carlosdev.Application.Posts.Models;

namespace Carlosdev.Application.Posts.Commands.CreatePost {
    public interface ICreatePostCommand {
        void Execute(PostModelBase postModel);
    }
}
