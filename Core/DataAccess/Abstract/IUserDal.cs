using Core.Entities.Concrete;

namespace Core.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
