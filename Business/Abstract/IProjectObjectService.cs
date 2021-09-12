using Core.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProjectObjectService
    {
        void Add(ProjectObject projectObject);
        void Update(ProjectObject projectObject);
        void Delete(ProjectObject projectObject);
        void DeleteAll();
        List<ProjectObject> GetAll();
        int GetNextId();
        List<ProjectObject> GetByUserId(int userId);
    }
}
