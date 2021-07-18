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
        void DeleteAll();
        List<StudentExercises> GetAll();
        StudentExercises GetById(int id);
        List<StudentExercisesDto> GetStudentExercisesDto();
        List<StudentExercises> GetByStudentId(int id, bool isActive);
        List<StudentExercises> GetByExerciseId(int id, bool isActive);
        List<StudentExercisesDto> GetStudentExercisesDtoById(int id);
        List<StudentExercisesDto> GetStudentExercisesDtoByStudentId(int id, bool isActive);
        List<StudentExercisesDto> GetStudentExercisesDtoByExerciseId(int id, bool isActive);
        List<StudentExercises> GetActive(bool active);
        List<StudentExercisesDto> GetActiveDto(bool active);
        List<StudentExercises> GetStudentExercisesByFullName(string text);
        List<StudentExercisesDto> GetStudentExercisesDtoByFullName(string text);
        List<StudentExercises> GetStudentExercisesByFirstName(string text);
        List<StudentExercisesDto> GetStudentExercisesDtoByFirstName(string text);
        List<StudentExercises> GetStudentExercisesByLastName(string text);
        List<StudentExercisesDto> GetStudentExercisesDtoByLastName(string text);
        List<StudentExercises> GetStudentExercisesByExerciseTitle(string text);
        List<StudentExercisesDto> GetStudentExercisesDtoByExerciseTitle(string text);
        int GetNextId();
    }
}
