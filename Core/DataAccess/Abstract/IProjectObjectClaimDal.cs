using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IProjectObjectClaimDal : IEntityRepository<ProjectObjectClaim>
    {
        List<ProjectObjectClaimDto> GetAllProjectObjectClaimDetails(Expression<Func<ProjectObjectClaim,bool>>filter=null);
    }
}
