using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Core.DependencyResolvers.Ninject
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClaimDal>().To<EfClaimDal>().InSingletonScope();
            Bind<IMainClaimDal>().To<EfMainClaimDal>().InSingletonScope();
            Bind<IProjectObjectDal>().To<EfProjectObjectDal>().InSingletonScope();
            Bind<IProjectObjectClaimDal>().To<EfProjectObjectClaimDal>().InSingletonScope();
            Bind<ISubsidiaryClaimDal>().To<EfSubsidiaryClaimDal>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<IUserClaimDal>().To<EfUserClaimDal>().InSingletonScope();
        }
    }
}
