using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStudentExercisesService 
    {
        void Add(StudentExercises studentExercises);
        void Update(StudentExercises studentExercises);
        void Delete(StudentExercises studentExercises);
        List<StudentExercises> GetAll();
        StudentExercises GetById(int id);
    }
}
