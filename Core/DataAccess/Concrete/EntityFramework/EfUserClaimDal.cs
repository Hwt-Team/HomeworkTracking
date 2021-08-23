using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfUserClaimDal : EfEntityRepositoryBase<UserClaim, CoreContext>, IUserClaimDal
    {
        public List<UserClaimDto> GetAllUserClaimDetails(Expression<Func<UserClaim, bool>> filter = null)
        {
            using (CoreContext context=new CoreContext())
            {
                var result = from uc in filter == null
                             ? context.UserClaims
                             : context.UserClaims.Where(filter)
                             join c in context.Claims on uc.ClaimId equals c.Id
                             join u in context.Users on uc.UserId equals u.Id
                             select new UserClaimDto
                             {
                                  UserClaimId=uc.Id,
                                  ClaimName=c.Name,
                                  FirstName=u.FirstName,
                                  LastName=u.LastName,
                                  Email=u.Email,
                                  UserName=u.UserName,
                                  Status=u.Status
                             };
                return result.ToList();
            }       
        }
    }
}
