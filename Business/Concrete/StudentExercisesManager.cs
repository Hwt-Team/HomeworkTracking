using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StudentExercisesManager : IStudentExercisesService
    {
        private IStudentExercisesDal _studentExercisesDal;

        public StudentExercisesManager(IStudentExercisesDal studentExercisesDal)
        {
            _studentExercisesDal = studentExercisesDal;
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
    }
}
