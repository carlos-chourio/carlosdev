using Carlosdev.Application.Interfaces.Persistence;
using Carlosdev.Application.Posts.Commands.CreatePost.Factory;
using Carlosdev.Application.Posts.Models;

namespace Carlosdev.Application.Posts.Commands.CreatePost {
    public class CreatePostCommand : ICreatePostCommand {
        private readonly IPostRepository postRepository;
        private readonly PostFactory postFactory;

        public CreatePostCommand(IPostRepository postRepository, PostFactory postFactory) {
            this.postRepository = postRepository;
            this.postFactory = postFactory;
        }

        public void Execute(PostModelBase postModel) {
            var post = postFactory.CreatePost(postModel);
            postRepository.Add(post);
            postRepository.SaveChanges();
        }
    }
}
