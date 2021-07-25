﻿using Business.Abstract;
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
            #region DataAccess
            Bind<IExerciseDal>().To<EfExerciseDal>().InSingletonScope();
            Bind<IGroupDal>().To<EfGroupDal>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();
            Bind<IStudentExercisesDal>().To<EfStudentExercisesDal>().InSingletonScope();
            Bind<ITaskDal>().To<EfTaskDal>().InSingletonScope();
            Bind<IStateDal>().To<EfStateDal>().InSingletonScope();
            Bind<IStudyingStudentDal>().To<EfStudyingStudentDal>().InSingletonScope();
            Bind<IGraduateStudentDal>().To<EfGraduateStudentDal>().InSingletonScope();
            Bind<IClaimDal>().To<EfClaimDal>().InSingletonScope();
            Bind<IUserClaimDal>().To<EfUserClaimDal>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            #endregion

            #region Business
            Bind<IExerciseService>().To<ExerciseManager>().InSingletonScope();
            Bind<IGroupService>().To<GroupManager>().InSingletonScope();
            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentExercisesService>().To<StudentExercisesManager>().InSingletonScope();
            Bind<ITaskService>().To<TaskManager>().InSingletonScope();
            Bind<IStateService>().To<StateManager>().InSingletonScope();
            Bind<IStudyingStudentService>().To<StudyingStudentManager>().InSingletonScope();
            Bind<IGraduateStudentService>().To<GraduateStudentManager>().InSingletonScope();
            Bind<IClaimService>().To<ClaimManager>().InSingletonScope();
            Bind<IUserClaimService>().To<UserClaimManager>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            #endregion
            
            Bind<NinjectModule>().To<BusinessModule>().InSingletonScope();
        }
    }
}
