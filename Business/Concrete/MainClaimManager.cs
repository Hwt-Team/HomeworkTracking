using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class MainClaimManager : IMainClaimService
    {
        private readonly IMainClaimDal _mainClaimDal;

        public MainClaimManager(IMainClaimDal mainClaimDal)
        {
            _mainClaimDal = mainClaimDal;
        }

        [ValidationAspect(typeof(MainClaimValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(MainClaim mainClaim)
        {
            this._mainClaimDal.Add(mainClaim);
        }

        [ValidationAspect(typeof(MainClaimValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(MainClaim mainClaim)
        {
            this._mainClaimDal.Update(mainClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(MainClaim mainClaim)
        {
            this._mainClaimDal.Delete(mainClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._mainClaimDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<MainClaim> GetAll()
        {
            return this._mainClaimDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public MainClaim GetById(int id)
        {
            return this._mainClaimDal.Get(c => c.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._mainClaimDal.GetNextId();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<MainClaim> GetOrderedMainClaims()
        {
            return this.GetAll().OrderBy(c => c.Priority).ToList();
        }
    }
}
