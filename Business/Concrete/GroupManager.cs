using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class GroupManager : IGroupService
    {
        private IGroupDal _groupDal;

        public GroupManager(IGroupDal groupDal)
        {
            _groupDal = groupDal;
        }

        public void Add(Group group)
        {
            _groupDal.Add(group);
        }

        public void Update(Group group)
        {
            _groupDal.Update(group);
        }

        public void Delete(Group group)
        {
            _groupDal.Delete(group);
        }

        public List<Group> GetAll()
        {
            return _groupDal.GetAll();
        }

        public Group GetById(int id)
        {
            return _groupDal.Get(g => g.Id == id);
        }
    }
}
