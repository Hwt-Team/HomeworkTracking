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
    public class StudyingStudentManager : IStudyingStudentService
    {
        private readonly IStudyingStudentDal _studyingStudentDal;

        public StudyingStudentManager(IStudyingStudentDal studyingStudentDal)
        {
            _studyingStudentDal = studyingStudentDal;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(StudyingStudentValidator))]
        public void Add(StudyingStudent studyingStudent)
        {
            this._studyingStudentDal.Add(studyingStudent);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(StudyingStudentValidator))]
        public void Update(StudyingStudent studyingStudent)
        {
            this._studyingStudentDal.Update(studyingStudent);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(StudyingStudent studyingStudent)
        {
            this._studyingStudentDal.Delete(studyingStudent);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._studyingStudentDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudyingStudent> GetAll()
        {
            return this._studyingStudentDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._studyingStudentDal.GetNextId();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public StudyingStudent GetById(int id)
        {
            return this._studyingStudentDal.Get(s => s.Id == id);
        }
    }
}
