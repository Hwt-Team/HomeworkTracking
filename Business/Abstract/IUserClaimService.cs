﻿using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserClaimService
    {
        void Add(UserClaim userClaim);
        void Update(UserClaim userClaim);
        void Delete(UserClaim userClaim);
        void DeleteAll();
        List<UserClaim> GetAll();
        UserClaim GetById(int id);
        int GetNextId();
        List<UserClaim> GetUserClaims(int userId);
    }
}
