using Ninject.Modules;

namespace FormsUI.DependencyResolvers
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<StudentForm>().To<StudentForm>();
            Bind<ExerciseForm>().To<ExerciseForm>();
            Bind<GroupForm>().To<GroupForm>();
        }
    }
}
