using System.Collections.Generic;
using Business.Abstract;
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

        public void Add(StudentExercises studentExercises)
        {
            _studentExercisesDal.Add(studentExercises);
        }

        public void Update(StudentExercises studentExercises)
        {
            _studentExercisesDal.Update(studentExercises);
        }

        public void Delete(StudentExercises studentExercises)
        {
            _studentExercisesDal.Delete(studentExercises);
        }

        public List<StudentExercises> GetAll()
        {
            return _studentExercisesDal.GetAll();
        }

        public StudentExercises GetById(int id)
        {
            return _studentExercisesDal.Get(s => s.Id == id);
        }

        public List<StudentExercisesDto> GetStudentExercisesDto()
        {
            return _studentExercisesDal.GetStudentExercisesDetails();
        }

        public List<StudentExercises> GetByStudentId(int id)
        {
            return _studentExercisesDal.GetAll(s => s.StudentId == id);
        }

        public List<StudentExercises> GetByExerciseId(int id)
        {
            return _studentExercisesDal.GetAll(s => s.ExerciseId == id);
        }

        public List<StudentExercisesDto> GetStudentExercisesDtoById(int id)
        {
            return _studentExercisesDal.GetStudentExercisesDetails(s => s.Id == id);
        }

        public List<StudentExercisesDto> GetStudentExercisesDtoByStudentId(int id)
        {
            var student = _studentService.GetById(id);
            return _studentExercisesDal.GetStudentExercisesDetails(s =>
                s.Id == id);
        }

        public List<StudentExercisesDto> GetStudentExercisesDtoByExerciseId(int id)
        {
            var exercise = _exerciseService.GetById(id);
            return _studentExercisesDal.GetStudentExercisesDetails(s => s.ExerciseId == id);
        }
    }
}
