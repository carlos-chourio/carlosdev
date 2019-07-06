using Carlosdev.Application.Posts.Models;
using Carlosdev.Common.Dates;
using Carlosdev.Domain.Posts;

namespace Carlosdev.Application.Posts.Commands.CreatePost.Factory {
    public class PostFactory {
        private readonly IDateService dateService;

        public PostFactory(IDateService dateService) 
        {
            this.dateService = dateService;
        }

        public Post CreatePost(PostModelBase postModel) {
            return new Post()
            {
                //Use Automapper
                Title = postModel.Title,
                Content = postModel.Content,
                UserId = postModel.UserId,
                CreationDate = dateService.GetCurrentDate(),
                LastDateModified = dateService.GetCurrentDate()
            };
            
        }
    }
}
