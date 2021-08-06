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
    public class UserClaimManager : IUserClaimService
    {
        private readonly IUserClaimDal _userClaimDal;

        public UserClaimManager(IUserClaimDal userClaimDal)
        {
            _userClaimDal = userClaimDal;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(UserClaimValidator))]
        public void Add(UserClaim userClaim)
        {
            this._userClaimDal.Add(userClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(UserClaimValidator))]
        public void Update(UserClaim userClaim)
        {
            this._userClaimDal.Update(userClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(UserClaim userClaim)
        {
            this._userClaimDal.Delete(userClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._userClaimDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<UserClaim> GetAll()
        {
            return this._userClaimDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public UserClaim GetById(int id)
        {
            return this._userClaimDal.Get(u => u.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._userClaimDal.GetNextId();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<UserClaim> GetUserClaims(int userId)
        {
            return this._userClaimDal.GetAll(u => u.UserId == userId);
        }
    }
}
