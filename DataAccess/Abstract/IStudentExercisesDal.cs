using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IStudentExercisesDal : IEntityRepository<StudentExercises>
    {
        List<StudentExercisesDto> GetStudentExercisesDetails
            (Expression<Func<StudentExercises, bool>> filter = null);
    }
}
