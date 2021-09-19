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
        private readonly IGraduateStudentDal _graduateStudentDal;
        private readonly IStudentService _studentService;

        public GraduateStudentManager(IGraduateStudentDal graduateStudentDal, IStudentService studentService)
        {
            _graduateStudentDal = graduateStudentDal;
            _studentService = studentService;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(GraduateStudentValidator))]
        public void Add(GraduateStudent graduateStudent)
        {
            this._studentService.Add(new Student
            {
                Id = graduateStudent.Id,
                Email = graduateStudent.Email,
                UserName = graduateStudent.UserName,
                FirstName = graduateStudent.FirstName,
                LastName = graduateStudent.LastName,
                GenderId = graduateStudent.GenderId,
                GroupId = graduateStudent.GroupId,
                PasswordHash = graduateStudent.PasswordHash,
                PasswordSalt = graduateStudent.PasswordSalt,
                Status = graduateStudent.Status
            });

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
            return this._studentService.GetNextId();
        }
    }
}
