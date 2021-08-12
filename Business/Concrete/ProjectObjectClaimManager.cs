using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Validation;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectObjectClaimManager : IProjectObjectClaimService
    {
        private IProjectObjectClaimDal _projectObjectClaimDal;
        public ProjectObjectClaimManager(IProjectObjectClaimDal projectObjectClaimDal)
        {
            _projectObjectClaimDal = projectObjectClaimDal;
        }
        [ValidationAspect(typeof(ProjectObjectClaimValidator))]
        public void Add(ProjectObjectClaim projectObjectClaim)
        {
            this._projectObjectClaimDal.Add(projectObjectClaim);
        }
        [ValidationAspect(typeof(ProjectObjectClaimValidator))]
        public void Update(ProjectObjectClaim projectObjectClaim)
        {
            this._projectObjectClaimDal.Update(projectObjectClaim);
        }

        public void Delete(ProjectObjectClaim projectObjectClaim)
        {
            this._projectObjectClaimDal.Delete(projectObjectClaim);
        }

        public void DeleteAll()
        {
            this._projectObjectClaimDal.DeleteAll();
        }

        public List<ProjectObjectClaim> GetAll()
        {
            return this._projectObjectClaimDal.GetAll();
        }

        public ProjectObjectClaim GetById(int id)
        {
            return _projectObjectClaimDal.Get(e => e.Id == id);
        }

        public int GetNextId()
        {
            return this._projectObjectClaimDal.GetNextId();
        }
    }
}
