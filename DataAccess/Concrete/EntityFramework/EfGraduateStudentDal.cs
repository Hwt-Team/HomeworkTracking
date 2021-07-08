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
    public class EfGraduateStudentDal : EfEntityRepositoryBase<GraduateStudent, HomeworkTrackingContext>, IGraduateStudentDal
    {
        public List<GraduateStudentDto> GetGraduateStudentDetails(Expression<Func<GraduateStudent, bool>> filter = null)
        {
            using (HomeworkTrackingContext context = new HomeworkTrackingContext())
            {
                var result =
                    from gs in filter == null ? context.GraduateStudents : context.GraduateStudents.Where(filter)
                    join g in context.Groups on gs.GroupId equals g.Id
                    select new GraduateStudentDto
                    {
                        GraduateStudentId = gs.Id,
                        FirstName = gs.FirstName,
                        LastName = gs.LastName,
                        GraduateDate = gs.GraduateDate,
                        GroupName = g.Name
                    };
                return result.ToList();
            }
        }
    }
}
