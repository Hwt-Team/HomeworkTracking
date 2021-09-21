using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System.Collections.Generic;

namespace Core.DataAccess.Abstract
{
    public interface IMainClaimDal : IEntityRepository<MainClaim>
    {
        List<MainClaim> GetMainClaimsByUserId(int userId);
    }
}
