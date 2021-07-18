using FormsUI.Forms.ExerciseForms;
using FormsUI.Forms.GroupForms;
using FormsUI.Forms.MessageBox;
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
            Bind<WarnMessageBox>().To<WarnMessageBox>().InSingletonScope();

        }
    }
}
