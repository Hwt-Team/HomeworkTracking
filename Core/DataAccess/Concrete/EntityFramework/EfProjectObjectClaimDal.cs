using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfProjectObjectClaimDal : EfEntityRepositoryBase<ProjectObjectClaim, CoreContext>, IProjectObjectClaimDal
    {
        public List<ProjectObjectClaimDto> GetAllProjectObjectClaimDetails(Expression<Func<ProjectObjectClaim, bool>> filter = null)
        {
            using (CoreContext context = new CoreContext())
            {
                var result = from poc in filter == null ? context.ProjectObjectClaims
                             : context.ProjectObjectClaims.Where(filter)
                             join po in context.ProjectObjects on poc.ProjectObjectId equals po.Id
                             join sc in context.SubsidiaryClaims on poc.SubsidiaryClaimId equals sc.Id
                             select new ProjectObjectClaimDto
                             { 
                                 ProjectObjectClaimId = poc.Id,
                                 SubsidiaryClaimName = sc.Name,
                                 ObjectAdress = $"{po.NameSpace}.{po.ClassName}.{po.ObjectName}"

                             };
                return result.ToList();

            }
        }
    }
}
