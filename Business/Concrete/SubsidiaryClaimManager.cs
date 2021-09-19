using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SubsidiaryClaimManager : ISubsidiaryClaimService
    {
        private readonly ISubsidiaryClaimDal _subsidiaryClaimDal;
        private readonly IClaimService _claimService;

        public SubsidiaryClaimManager(ISubsidiaryClaimDal subsidiaryClaimDal, IClaimService claimService)
        {
            _subsidiaryClaimDal = subsidiaryClaimDal;
            _claimService = claimService;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(SubsidiaryClaimValidator))]
        public void Add(SubsidiaryClaim subsidiaryClaim)
        {
            this._claimService.Add(new Claim
            {
                Id = subsidiaryClaim.Id,
                Name = subsidiaryClaim.Name
            });

            this._subsidiaryClaimDal.Add(subsidiaryClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(SubsidiaryClaimValidator))]
        public void Update(SubsidiaryClaim subsidiaryClaim)
        {
            this._subsidiaryClaimDal.Update(subsidiaryClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(SubsidiaryClaim subsidiaryClaim)
        {
            this._subsidiaryClaimDal.Delete(subsidiaryClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._subsidiaryClaimDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<SubsidiaryClaim> GetAll()
        {
            return this._subsidiaryClaimDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public SubsidiaryClaim GetById(int id)
        {
            return this._subsidiaryClaimDal.Get(c => c.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._claimService.GetNextId();
        }

    }
}
