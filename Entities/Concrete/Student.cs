using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Student : User, IEntity
    {
        public int GroupId { get; set; }
    }
}
