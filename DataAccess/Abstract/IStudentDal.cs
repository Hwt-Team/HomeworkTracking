using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IStudentDal : IEntityRepository<Student>
    {
    }
}
