using Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectObjectTypeManager : IProjectObjectTypeService
    {
        private readonly IProjectObjectTypeDal _projectObjectType;

        public ProjectObjectTypeManager(IProjectObjectTypeDal projectObjectType)
        {
            _projectObjectType = projectObjectType;
        }

        public void Add(ProjectObjectType objectType)
        {
            _projectObjectType.Add(objectType);
        }

        public void Delete(ProjectObjectType objectType)
        {
            _projectObjectType.Delete(objectType);
        }

        public void DeleteAll()
        {
            _projectObjectType.DeleteAll();
        }

        public List<ProjectObjectType> GetAll()
        {
           return  _projectObjectType.GetAll();
        }      
        public int GetNextId()
        {
            return _projectObjectType.GetNextId();
        }

        public void Update(ProjectObjectType objectType)
        {       
            _projectObjectType.Update(objectType);
        }
    }
}
