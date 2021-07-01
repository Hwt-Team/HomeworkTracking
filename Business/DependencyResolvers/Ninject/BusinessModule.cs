using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IExerciseDal>().To<EfExerciseDal>();
            Bind<IGroupDal>().To<EfGroupDal>();
            Bind<IStudentDal>().To<EfStudentDal>();
            Bind<IStudentExercisesDal>().To<EfStudentExercisesDal>();

            Bind<IExerciseService>().To<ExerciseManager>();
            Bind<IGroupService>().To<GroupManager>();
            Bind<IStudentService>().To<StudentManager>();
            Bind<IStudentExercisesService>().To<StudentExercisesManager>();
        }
    }
}
