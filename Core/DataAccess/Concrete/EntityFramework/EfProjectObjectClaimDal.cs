using Core.DataAccess.Abstract;
using Core.Entities.Concrete;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfProjectObjectClaimDal : EfEntityRepositoryBase<ProjectObjectClaim, Context>, IProjectObjectClaimDal
    {
    }
}
