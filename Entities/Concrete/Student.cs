using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Student : User, IEntity
    {
        public int GroupId { get; set; }
    }
}
