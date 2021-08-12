using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProjectObjectClaimService
    {
        void Add(ProjectObjectClaim projectObjectClaim);
        void Update(ProjectObjectClaim projectObjectClaim);
        void Delete(ProjectObjectClaim projectObjectClaim);
        void DeleteAll();
        List<ProjectObjectClaim> GetAll();
        ProjectObjectClaim GetById(int id);
        int GetNextId();
    }
}
