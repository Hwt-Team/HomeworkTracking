using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IUserClaimDal : IEntityRepository<UserClaim>
    {
        List<UserClaimDto> GetAllUserClaimDetails(Expression<Func<UserClaim,bool>> filter=null );
    }
}
