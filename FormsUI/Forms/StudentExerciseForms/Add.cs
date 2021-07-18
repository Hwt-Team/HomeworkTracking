using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentExerciseForms
{
    public partial class Add : Form
    {
        private IStudentExercisesService _studentExercisesService;
        public Add()
        {
            InitializeComponent();
            this._studentExercisesService = InstanceFactory.GetInstance<IStudentExercisesService>(new BusinessModule());
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new student&exercise will be added.",
                Ok = AddStudentExercise, 
                Cancel = Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel() { }

        private void AddStudentExercise()
        {
            _studentExercisesService.Add(new StudentExercises
            {
                Id = this._studentExercisesService.GetNextId(),
                StudentId = int.Parse(tbxStudentId.Text),
                ExerciseId = int.Parse(tbxExerciseId.Text),
                Active = true
            });
        }
    }
}
