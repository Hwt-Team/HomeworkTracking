using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMainClaimService
    {
        void Add(MainClaim mainClaim);
        void Update(MainClaim mainClaim);
        void Delete(MainClaim mainClaim);
        void DeleteAll();
        List<MainClaim> GetAll();
        MainClaim GetById(int id);
        int GetNextId();
        List<MainClaim> GetOrderedMainClaims();
    }
}
