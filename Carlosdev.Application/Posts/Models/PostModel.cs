using Carlosdev.Application.Interfaces;
using Carlosdev.Domain.Tags;
using System.Collections.Generic;

namespace Carlosdev.Application.Posts.Models {
    public class PostModelBase : IEntityModel {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? CategoryId { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public int? UserId { get; set; }
    }
}
