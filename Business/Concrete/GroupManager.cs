using System.Collections.Generic;
using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class GroupManager : IGroupService
    {
        private IGroupDal _groupDal;

        public GroupManager(IGroupDal groupDal)
        {
            _groupDal = groupDal;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(GroupValidator))]
        public void Add(Group group)
        {
            _groupDal.Add(group);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(GroupValidator))]
        public void Update(Group group)
        {
            _groupDal.Update(group);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Group group)
        {
            _groupDal.Delete(group);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Group> GetAll()
        {
            return _groupDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public Group GetById(int id)
        {
            return _groupDal.Get(g => g.Id == id);
        }
    }
}
