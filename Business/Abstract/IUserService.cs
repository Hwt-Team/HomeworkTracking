using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        void DeleteAll();
        List<User> GetAll();
        User GetById(int id);
        int GetNextId();
    }
}
