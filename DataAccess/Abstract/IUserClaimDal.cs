using Core.DataAccess.Abstract;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserClaimDal : IEntityRepository<UserClaim>
    {
    }
}
