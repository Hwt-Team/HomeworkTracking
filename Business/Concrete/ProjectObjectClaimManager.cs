using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectObjectClaimManager : IProjectObjectClaimService
    {
        private IProjectObjectClaimDal _projectObjectClaimDal;

        public ProjectObjectClaimManager(IProjectObjectClaimDal projectObjectClaimDal)
        {
            _projectObjectClaimDal = projectObjectClaimDal;
        }

        [ValidationAspect(typeof(ProjectObjectClaimValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(ProjectObjectClaim projectObjectClaim)
        {
            this._projectObjectClaimDal.Add(projectObjectClaim);
        }

        [ValidationAspect(typeof(ProjectObjectClaimValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(ProjectObjectClaim projectObjectClaim)
        {
            this._projectObjectClaimDal.Update(projectObjectClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(ProjectObjectClaim projectObjectClaim)
        {
            this._projectObjectClaimDal.Delete(projectObjectClaim);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._projectObjectClaimDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<ProjectObjectClaim> GetAll()
        {
            return this._projectObjectClaimDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public ProjectObjectClaim GetById(int id)
        {
            return _projectObjectClaimDal.Get(e => e.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._projectObjectClaimDal.GetNextId();
        }

    }
}
