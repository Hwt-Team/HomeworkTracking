using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Claim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
