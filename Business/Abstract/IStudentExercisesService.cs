using System.Collections.Generic;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IStudentExercisesService 
    {
        void Add(StudentExercises studentExercises);
        void Update(StudentExercises studentExercises);
        void Delete(StudentExercises studentExercises);
        List<StudentExercises> GetAll();
        StudentExercises GetById(int id);
        List<StudentExercisesDto> GetStudentExercisesDto();
        List<StudentExercises> GetByStudentId(int id);
        List<StudentExercises> GetByExerciseId(int id);
        List<StudentExercisesDto> GetStudentExercisesDtoById(int id);
        List<StudentExercisesDto> GetStudentExercisesDtoByStudentId(int id);
        List<StudentExercisesDto> GetStudentExercisesDtoByExerciseId(int id);
    }
}
