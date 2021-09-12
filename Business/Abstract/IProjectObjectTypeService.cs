using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProjectObjectTypeService
    {
        void Add(ProjectObjectType objectType);
        void Update(ProjectObjectType objectType);
        void Delete(ProjectObjectType objectType);
        void DeleteAll();
        List<ProjectObjectType> GetAll();       
        int GetNextId();
    }
}
