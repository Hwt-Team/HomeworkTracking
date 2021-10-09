using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfMainClaimDal : EfEntityRepositoryBase<MainClaim, CoreContext>, IMainClaimDal
    {
        public List<MainClaim> GetMainClaimsByUserId(int userId)
        {
            using (CoreContext context=new CoreContext())
            {
                var result = from uc in context.UserClaims
                             join c in context.Claims on uc.ClaimId equals c.Id
                             join u in context.Users on uc.UserId equals u.Id
                             join m in context.MainClaims on c.Id equals m.Id
                             where u.Id == userId
                             select m;
                             
                return result.OrderBy(p => p.Priority).ToList();
            }
        }
    }
}
