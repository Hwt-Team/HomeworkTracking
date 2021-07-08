using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IGraduateStudentDal : IEntityRepository<GraduateStudent>
    {
        List<GraduateStudentDto> GetGraduateStudentDetails(Expression<Func<GraduateStudent, bool>> filter = null);
    }
}
