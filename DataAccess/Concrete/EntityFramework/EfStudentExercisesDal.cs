using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentExercisesDal : EfEntityRepositoryBase<StudentExercises, HomeworkTrackingContext>, IStudentExercisesDal
    {
        public List<StudentExercisesDto> GetStudentExercisesDetails(Expression<Func<StudentExercises, bool>> filter = null)
        {
            using (HomeworkTrackingContext context = new HomeworkTrackingContext())
            {
                var result = from se in filter == null ? context.StudentExercises : context.StudentExercises.Where(filter)
                    join e in context.Exercises on se.ExerciseId equals e.Id
                    join s in context.Students on se.StudentId equals s.Id
                    select new StudentExercisesDto
                    {
                        StudentExercisesId = se.Id,
                        FullName = s.FirstName + " " + s.LastName,
                        Title = e.Title,
                        Active = se.Active
                    };

                return result.ToList();
            }
        }
    }
}
