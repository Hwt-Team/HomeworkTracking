
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISubsidiaryClaimService
    {
        void Add(SubsidiaryClaim subsidiaryClaim);
        void Update(SubsidiaryClaim subsidiaryClaim);
        void Delete(SubsidiaryClaim subsidiaryClaim);
        void DeleteAll();
        List<SubsidiaryClaim> GetAll();
        SubsidiaryClaim GetById(int id);
        int GetNextId();
    }
}
