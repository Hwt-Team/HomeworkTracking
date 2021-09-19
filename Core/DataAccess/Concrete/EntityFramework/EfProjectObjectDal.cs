using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System.Linq;
using System.Collections.Generic;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfProjectObjectDal : EfEntityRepositoryBase<ProjectObject, CoreContext>, IProjectObjectDal
    {
        public List<ProjectObject> GetProjectObjectsByUser(int userId)
        {
            using (CoreContext context = new CoreContext())
            {
                var result = from po in context.ProjectObjects
                             join poc in context.ProjectObjectClaims on po.Id equals poc.ProjectObjectId
                             join sc in context.SubsidiaryClaims on poc.SubsidiaryClaimId equals sc.Id
                             join uc in context.UserClaims on sc.Id equals uc.ClaimId
                             where uc.UserId == userId
                             select po;

                return result.ToList();
            }
        }
    }
}
