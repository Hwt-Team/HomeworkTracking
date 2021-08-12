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
    public class MainClaimManager : IMainClaimService
    {
        private readonly IMainClaimDal _mainClaimDal;

        public MainClaimManager(IMainClaimDal mainClaimDal)
        {
            _mainClaimDal = mainClaimDal;
        }

        [ValidationAspect(typeof(MainClaimValidator))]
        public void Add(MainClaim mainClaim)
        {
            this._mainClaimDal.Add(mainClaim);
        }

        [ValidationAspect(typeof(MainClaimValidator))]
        public void Update(MainClaim mainClaim)
        {
            this._mainClaimDal.Update(mainClaim);
        }

        public void Delete(MainClaim mainClaim)
        {
            this._mainClaimDal.Delete(mainClaim);
        }

        public void DeleteAll()
        {
            this._mainClaimDal.DeleteAll();
        }

        public List<MainClaim> GetAll()
        {
            return this._mainClaimDal.GetAll();
        }

        public MainClaim GetById(int id)
        {
            return this._mainClaimDal.Get(c => c.Id == id);
        }

        public int GetNextId()
        {
            return this._mainClaimDal.GetNextId();
        }
    }
}
