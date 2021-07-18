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
            Bind<IExerciseDal>().To<EfExerciseDal>().InSingletonScope();
            Bind<IGroupDal>().To<EfGroupDal>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();
            Bind<IStudentExercisesDal>().To<EfStudentExercisesDal>().InSingletonScope();
            Bind<ITaskDal>().To<EfTaskDal>().InSingletonScope();

            Bind<IExerciseService>().To<ExerciseManager>().InSingletonScope();
            Bind<IGroupService>().To<GroupManager>().InSingletonScope();
            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentExercisesService>().To<StudentExercisesManager>().InSingletonScope();
            Bind<ITaskService>().To<TaskManager>().InSingletonScope();

            Bind<NinjectModule>().To<BusinessModule>().InSingletonScope();
        }
    }
}
