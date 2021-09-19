using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProjectObjectManager : IProjectObjectService
    {
        private readonly IProjectObjectDal _projectObjectDal;
        private readonly IProjectObjectTypeDal _projectObjectTypeDal;

        public ProjectObjectManager(IProjectObjectDal projectObjectDal, IProjectObjectTypeDal projectObjectTypeDal)
        {
            _projectObjectDal = projectObjectDal;
            _projectObjectTypeDal = projectObjectTypeDal;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(ProjectObjectValidator))]
        public void Add(ProjectObject projectObject)
        {
            this._projectObjectDal.Add(projectObject);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(ProjectObjectValidator))]
        public void Update(ProjectObject projectObject)
        {
            this._projectObjectDal.Update(projectObject);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(ProjectObject projectObject)
        {
            this._projectObjectDal.Delete(projectObject);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._projectObjectDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<ProjectObject> GetAll()
        {
            return this._projectObjectDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._projectObjectDal.GetNextId();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<ProjectObject> GetByUserId(int userId)
        {
            return this._projectObjectDal.GetProjectObjectsByUser(userId);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public ProjectObject GetByObjectType(string objectType)
        {
            return this._projectObjectDal
                .Get(p => string.Join(".", new string[] { p.NameSpace, p.ClassName, p.ObjectName }) == this._projectObjectTypeDal.Get(t => t.Name == objectType).Name);
        }

        public bool IsAdministrativeProjectObject(string fullName) => this._projectObjectTypeDal
            .Get(t => t.Id == this._projectObjectDal
                .Get(p => string.Join(".", new string[] { p.NameSpace, p.ClassName, p.ObjectName }) == fullName).ObjectTypeId).Name == "Administrative";
        
    }
}
