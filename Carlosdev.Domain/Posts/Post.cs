using Carlosdev.Domain.Categories;
using Carlosdev.Domain.Interfaces;
using Carlosdev.Domain.Tags;
using Carlosdev.Domain.Users;
using System;
using System.Collections.Generic;

namespace Carlosdev.Domain.Posts
{
    public class Post : IEntity
    {
        public int Id { get;set; }
        public string Title { get;set; }
        public string Content { get;set; }
        public int? CategoryId { get;set; }
        public Category Category { get;set; }
        public ICollection<Tag> Tags { get;set; }
        public int? UserId { get;set; }
        public User User { get;set; }
        public DateTime CreationDate { get;set; }
        public DateTime LastDateModified { get;set; }
    }
}