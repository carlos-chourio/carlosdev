using Carlosdev.Domain.Interfaces;

namespace Carlosdev.Domain.Categories
{
    public class Category : IEntity
    {
        public int Id { get;set; }
        public string Name { get;set; }
        public string Description { get;set; }
    }

}