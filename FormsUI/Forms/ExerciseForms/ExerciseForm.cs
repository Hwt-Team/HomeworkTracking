using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.ExerciseForms
{
    public partial class ExerciseForm : Form
    {
        private IExerciseService _exerciseService;
        public ExerciseForm()
        {
            InitializeComponent();
            this._exerciseService = InstanceFactory
                .GetInstance<IExerciseService>(new BusinessModule());
        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            LoadExercises();
        }


        private void LoadExercises()
        {
            dgwExercises.DataSource = this._exerciseService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadExercises();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = InstanceFactory.GetInstance<TaskForms.Update>(new FormModule());
            var cells = this.dgwExercises.CurrentRow?.Cells;
            updateForm.Id = (int) cells[0].Value;
            updateForm.Title = cells[1].Value.ToString();
            updateForm.Deadline = (DateTime) cells[2].Value;
            updateForm.Show();
            LoadExercises();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Selected exercise will be deleted.",
                Ok = DeleteExercise,
                Cancel = Cancel
            });
        }

        private void DeleteExercise()
        {
            this._exerciseService.Delete(new Exercise
            {
                Id = (int)dgwExercises.CurrentRow?.Cells[0].Value
            });
            LoadExercises();
        }

        private void dgwExercises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
           {
               Caption = "System",
               Title = this.dgwExercises.CurrentRow?.Cells[1].Value.ToString()
           });
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "All data will be deleted.",
                Ok = DeleteAll,
                Cancel = Cancel
            });
            LoadExercises();
        }

        private void DeleteAll()
        {
            this._exerciseService.DeleteAll();
        }

        private void Cancel() { }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadExercises();
        }
    }
}
