using System.Collections.Generic;
using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class StudentExercisesManager : IStudentExercisesService
    {
        private IStudentExercisesDal _studentExercisesDal;
        private IStudentService _studentService;
        private IExerciseService _exerciseService;

        public StudentExercisesManager(IStudentExercisesDal studentExercisesDal, IStudentService studentService, IExerciseService exerciseService)
        {
            _studentExercisesDal = studentExercisesDal;
            _studentService = studentService;
            _exerciseService = exerciseService;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(StudentExercisesValidator))]
        public void Add(StudentExercises studentExercises)
        {
            _studentExercisesDal.Add(studentExercises);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(StudentExercisesValidator))]
        public void Update(StudentExercises studentExercises)
        {
            _studentExercisesDal.Update(studentExercises);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(StudentExercises studentExercises)
        {
            _studentExercisesDal.Delete(studentExercises);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._studentExercisesDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercises> GetAll()
        {
            return _studentExercisesDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public StudentExercises GetById(int id)
        {
            return _studentExercisesDal.Get(s => s.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercisesDto> GetStudentExercisesDto()
        {
            return _studentExercisesDal.GetStudentExercisesDetails();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercises> GetByStudentId(int id, bool isActive)
        {
            return _studentExercisesDal.GetAll(s => s.StudentId == id & s.Active == isActive);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercises> GetByExerciseId(int id, bool isActive)
        {
            return _studentExercisesDal.GetAll(s => s.ExerciseId == id & s.Active == isActive);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercisesDto> GetStudentExercisesDtoById(int id)
        {
            return _studentExercisesDal.GetStudentExercisesDetails
                (s => s.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercisesDto> GetStudentExercisesDtoByStudentId(int id, bool isActive)
        {
            return _studentExercisesDal.GetStudentExercisesDetails(s =>
                s.StudentId == id & s.Active == isActive);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercisesDto> GetStudentExercisesDtoByExerciseId(int id, bool isActive)
        {
            return _studentExercisesDal.GetStudentExercisesDetails
                (s => s.ExerciseId == id & s.Active == isActive);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercises> GetActive(bool active)
        {
            return _studentExercisesDal.GetAll(s => s.Active == active);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercisesDto> GetActiveDto(bool active)
        {
            return _studentExercisesDal.GetStudentExercisesDetails(s => s.Active == active);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercises> GetStudentExercisesByFullName(string text)
        {
            var filteredStudentList = _studentService.GetByFullName(text);

            List<StudentExercises> result = new List<StudentExercises>();

            foreach (var student in filteredStudentList)
            {
                result.AddRange(_studentExercisesDal.GetAll(se=>se.StudentId == student.Id));
            }

            return result;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercisesDto> GetStudentExercisesDtoByFullName(string text)
        {
            var filteredStudentList = _studentService.GetByFullName(text);

            List<StudentExercisesDto> result = new List<StudentExercisesDto>();

            foreach (var student in filteredStudentList)
            {
                result.AddRange(_studentExercisesDal.GetStudentExercisesDetails(se=>se.StudentId == student.Id));
            }

            return result;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercises> GetStudentExercisesByFirstName(string text)
        {
            var filteredStudentList = _studentService.GetByFirstName(text);

            List<StudentExercises> result = new List<StudentExercises>();

            foreach (var student in filteredStudentList)
            {
                result.AddRange(_studentExercisesDal.GetAll(se => se.StudentId == student.Id));
            }

            return result;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercisesDto> GetStudentExercisesDtoByFirstName(string text)
        {
            var filteredStudentList = _studentService.GetByFirstName(text);

            List<StudentExercisesDto> result = new List<StudentExercisesDto>();

            foreach (var student in filteredStudentList)
            {
                result.AddRange(_studentExercisesDal.GetStudentExercisesDetails(se => se.StudentId == student.Id));
            }

            return result;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercises> GetStudentExercisesByLastName(string text)
        {
            var filteredStudentList = _studentService.GetByLastName(text);

            List<StudentExercises> result = new List<StudentExercises>();

            foreach (var student in filteredStudentList)
            {
                result.AddRange(_studentExercisesDal.GetAll(se => se.StudentId == student.Id));
            }

            return result;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StudentExercisesDto> GetStudentExercisesDtoByLastName(string text)
        {
            var filteredStudentList = _studentService.GetByLastName(text);

            List<StudentExercisesDto> result = new List<StudentExercisesDto>();

            foreach (var student in filteredStudentList)
            {
                result.AddRange(_studentExercisesDal.GetStudentExercisesDetails(se => se.StudentId == student.Id));
            }

            return result;
        }

        public List<StudentExercises> GetStudentExercisesByExerciseTitle(string text)
        {
            var filteredList = this._exerciseService.GetByTitle(text);

            var result = new List<StudentExercises>();

            foreach (var exercise in filteredList)
            {
                result.AddRange(this._studentExercisesDal.GetAll(s=>s.ExerciseId == exercise.Id));
            }

            return result;
        }

        public List<StudentExercisesDto> GetStudentExercisesDtoByExerciseTitle(string text)
        {
            var filteredList = this._exerciseService.GetByTitle(text);

            var result = new List<StudentExercisesDto>();

            foreach (var exercise in filteredList)
            {
                result.AddRange(this._studentExercisesDal.GetStudentExercisesDetails(s=>s.ExerciseId == exercise.Id));
            }

            return result;
        }

        public StudentExercises GetLastRecord()
        {
            return this._studentExercisesDal.GetLastRecord();
        }
    }
}
