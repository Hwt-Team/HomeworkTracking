using Core.DataAccess.Abstract;
using Core.Entities.Concrete;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfProjectObjectTypeDal : EfEntityRepositoryBase<ProjectObjectType,CoreContext>,IProjectObjectTypeDal
    {

    }
}
