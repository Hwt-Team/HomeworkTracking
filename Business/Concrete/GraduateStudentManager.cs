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
    public class GraduateStudentManager : IGraduateStudentService
    {
        private IGraduateStudentDal _graduateStudentDal;

        public GraduateStudentManager(IGraduateStudentDal graduateStudentDal)
        {
            _graduateStudentDal = graduateStudentDal;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(GraduateStudentValidator))]
        public void Add(GraduateStudent graduateStudent)
        {
            this._graduateStudentDal.Add(graduateStudent);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(GraduateStudentValidator))]
        public void Update(GraduateStudent graduateStudent)
        {
            this._graduateStudentDal.Update(graduateStudent);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(GraduateStudent graduateStudent)
        {
            this._graduateStudentDal.Delete(graduateStudent);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._graduateStudentDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<GraduateStudent> GetAll()
        {
            return this._graduateStudentDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public GraduateStudent GetById(int id)
        {
            return this._graduateStudentDal.Get(g => g.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._graduateStudentDal.GetNextId();
        }
    }
}
