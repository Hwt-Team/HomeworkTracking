using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentExerciseForms
{
    public partial class Update : Form
    {
        private IStudentExercisesService _studentExercisesService;
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExerciseId { get; set; }
        public bool Active { get; set; }

        public Update()
        {
            InitializeComponent();
            this._studentExercisesService = InstanceFactory.GetInstance<IStudentExercisesService>(new BusinessModule());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A student&exercise will be updated.",
                Ok = UpdateStudentExercise,
                Cancel = Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.tbxStudentId.Text = this.StudentId.ToString();
            this.tbxExerciseId.Text = this.ExerciseId.ToString();
            this.chbxActive.CheckState = this.Active == true
                ? CheckState.Checked
                : CheckState.Unchecked;
        }

        private void Cancel() { }

        private void UpdateStudentExercise()
        {
            _studentExercisesService.Update(new StudentExercises
            {
                Id = this.Id,
                StudentId = int.Parse(tbxStudentId.Text),
                ExerciseId = int.Parse(tbxStudentId.Text),
                Active = chbxActive.Checked
            });
        }
    }
}
