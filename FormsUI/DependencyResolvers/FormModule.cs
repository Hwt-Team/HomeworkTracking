using FormsUI.Forms.ExerciseForms;
using FormsUI.Forms.GroupForms;
using FormsUI.Forms.MainMenu;
using FormsUI.Forms.MessageBox;
using FormsUI.Forms.StateForms;
using FormsUI.Forms.StudentExerciseForms;
using FormsUI.Forms.StudentForms.Both;
using FormsUI.Forms.StudentForms.Graduates;
using FormsUI.Forms.StudentForms.Studies;
using FormsUI.Forms.TaskForms;
using Ninject.Modules;

namespace FormsUI.DependencyResolvers
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            #region Forms

            Bind<StudentForm>().To<StudentForm>();
            Bind<ExerciseForm>().To<ExerciseForm>();
            Bind<GroupForm>().To<GroupForm>();
            Bind<BaseForm>().To<BaseForm>();
            Bind<StateForm>().To<StateForm>();
            Bind<StudentExerciseForm>().To<StudentExerciseForm>();
            Bind<StudiesForm>().To<StudiesForm>();
            Bind<GraduateForm>().To<GraduateForm>();
            Bind<TaskForm>().To<TaskForm>();

            #endregion

            #region Add & Update

            Bind<Forms.ExerciseForms.Add>().To<Forms.ExerciseForms.Add>();
            Bind<Forms.ExerciseForms.Update>().To<Forms.ExerciseForms.Update>();
            Bind<Forms.GroupForms.Add>().To<Forms.GroupForms.Add>();
            Bind<Forms.GroupForms.Update>().To<Forms.GroupForms.Update>();
            Bind<Forms.StateForms.Add>().To<Forms.StateForms.Add>();
            Bind<Forms.StateForms.Update>().To<Forms.StateForms.Update>();
            Bind<Forms.StudentExerciseForms.Add>().To<Forms.StudentExerciseForms.Add>();
            Bind<Forms.StudentExerciseForms.Update>().To<Forms.StudentExerciseForms.Update>();
            Bind<Forms.StudentExerciseForms.Search>().To<Forms.StudentExerciseForms.Search>();
            Bind<Forms.TaskForms.Add>().To<Forms.TaskForms.Add>();
            Bind<Forms.TaskForms.Update>().To<Forms.TaskForms.Update>();

            #endregion

            Bind<WarnMessageBox>().To<WarnMessageBox>().InSingletonScope();
            
        }
    } 
}
