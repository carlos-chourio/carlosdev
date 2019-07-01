using Carlosdev.Domain.Interfaces;

namespace Carlosdev.Domain.Users
{
    public class User : IEntity
    {
        public int Id { get;set; }
        public string UserName { get;set; }
        public string FirstName { get;set; }
        public string LastName { get;set; }
    }
}