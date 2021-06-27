﻿using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentExercisesDal : EfEntityRepositoryBase<StudentExercises, HomeworkTrackingContext>, IStudentExercisesDal
    {
    }
}
