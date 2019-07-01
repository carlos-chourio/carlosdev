using Carlosdev.Domain.Interfaces;
using Carlosdev.Domain.Posts;
using Carlosdev.Domain.Users;
using System;

namespace Carlosdev.Domain.Comments
{
    public class Comment : IEntity
    {
        public int Id { get;set; }
        public string Title { get;set; }
        public string Content { get;set; }
        public int? UserId { get;set; }
        public User User { get;set; }
        public int? PostId { get;set; }
        public Post Post { get;set; } 
        public DateTime CreationDate { get;set; }
        public DateTime LastModifiedDate { get;set; }
    }
}