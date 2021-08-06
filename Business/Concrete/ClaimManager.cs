using System.Collections.Generic;
using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class ClaimManager : IClaimService
    {
        private readonly IClaimDal _claimDal;

        public ClaimManager(IClaimDal claimDal)
        {
            _claimDal = claimDal;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(ClaimValidator))]
        public void Add(Claim claim)
        {
            this._claimDal.Add(claim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(ClaimValidator))]
        public void Update(Claim claim)
        {
            this._claimDal.Update(claim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Claim claim)
        {
            this._claimDal.Delete(claim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._claimDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Claim> GetAll()
        {
            return this._claimDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public Claim GetById(int id)
        {
            return this._claimDal.Get(c => c.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._claimDal.GetNextId();
        }
    }
}
