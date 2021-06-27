using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IGroupService
    {
        void Add(Group group);
        void Update(Group group);
        void Delete(Group group);
        List<Group> GetAll();
        Group GetById(int id);
    }
}
