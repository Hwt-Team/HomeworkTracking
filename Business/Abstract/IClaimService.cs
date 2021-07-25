using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IClaimService
    {
        void Add(Claim claim);
        void Update(Claim claim);
        void Delete(Claim claim);
        void DeleteAll();
        List<Claim> GetAll();
        Claim GetById(int id);
        int GetNextId();
    }
}
