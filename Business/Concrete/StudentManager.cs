using System.Collections.Generic;
using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;
        private readonly IUserService _userService;

        public StudentManager(IStudentDal studentDal, IUserService userService)
        {
            _studentDal = studentDal;
            _userService = userService;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(StudentValidator))]
        public void Add(Student student)
        {
            this._userService.Add(new User
            {
                Id = student.Id,
                Email = student.Email,
                UserName = student.UserName,
                FirstName = student.FirstName,
                LastName = student.LastName,
                GenderId = student.GenderId,
                PasswordHash = student.PasswordHash,
                PasswordSalt = student.PasswordSalt,
                Status = student.Status
            });

            _studentDal.Add(student);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(StudentValidator))]
        public void Update(Student student)
        {
            _studentDal.Update(student);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._studentDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public Student GetById(int id)
        {
            return _studentDal.Get(s => s.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Student> GetByFirstName(string name)
        {
            return _studentDal.GetAll(s => s.FirstName.Contains(name));
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Student> GetByLastName(string name)
        {
            return _studentDal.GetAll(s => s.LastName.Contains(name));
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Student> GetByFullName(string name)
        {
            return _studentDal.GetAll(s => (s.FirstName + s.LastName).Contains(name));
        }

        public int GetNextId()
        {
            return this._userService.GetNextId();
        }
    }
}
