using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Core.DataAccess.Abstract
{
    public interface IProjectObjectDal : IEntityRepository<ProjectObject>
    {
        List<ProjectObject> GetProjectObjectsByUser(int userId);
    }
}
