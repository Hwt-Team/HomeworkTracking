using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Validation;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SubsidiaryClaimManager : ISubsidiaryClaimService
    {
        private readonly ISubsidiaryClaimDal _subsidiaryClaimDal;

        public SubsidiaryClaimManager(ISubsidiaryClaimDal subsidiaryClaimDal)
        {
            _subsidiaryClaimDal = subsidiaryClaimDal;
        }
        [ValidationAspect(typeof(SubsidiaryClaimValidator))]
        public void Add(SubsidiaryClaim subsidiaryClaim)
        {
            this._subsidiaryClaimDal.Add(subsidiaryClaim);
        }
        [ValidationAspect(typeof(SubsidiaryClaimValidator))]
        public void Update(SubsidiaryClaim subsidiaryClaim)
        {
            this._subsidiaryClaimDal.Update(subsidiaryClaim);
        }
        public void Delete(SubsidiaryClaim subsidiaryClaim)
        {
            this._subsidiaryClaimDal.Delete(subsidiaryClaim);
        }

        public void DeleteAll()
        {
            this._subsidiaryClaimDal.DeleteAll();
        }

        public List<SubsidiaryClaim> GetAll()
        {
            return this._subsidiaryClaimDal.GetAll();
        }

        public SubsidiaryClaim GetById(int id)
        {
            return this._subsidiaryClaimDal.Get(c => c.Id == id);
        }

        public int GetNextId()
        {
            return this._subsidiaryClaimDal.GetNextId();
        }

    }
}
