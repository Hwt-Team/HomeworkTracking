using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentExerciseForms
{
    public partial class StudentExerciseForm : Form
    {
        private readonly IStudentExercisesService _studentExercisesService;
        private IStudentService _studentService;
        private IExerciseService _exerciseService;
        private bool _isUser = false;

        public StudentExerciseForm()
        {
            this._studentService = InstanceFactory
                .GetInstance<IStudentService>(new BusinessModule());
            InitializeComponent();
            this._studentExercisesService = InstanceFactory
                .GetInstance<IStudentExercisesService>(new BusinessModule());
            this._exerciseService = InstanceFactory
                .GetInstance<IExerciseService>(new BusinessModule());
        }

        private void StudentExerciseForm_Load(object sender, EventArgs e)
        {
            CheckDataSourceForLoad();
            DesignDataGridView(dgwStudentExercises);
        }

        private void SetVisibilityToStudentExercises(bool value)
        {
            dgwStudentExercises.Visible = value;
        }

        private void DesignDataGridView(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 30, 45);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 21, 32);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void LoadStudentExercisesForUser()
        {
            dgwStudentExercises.DataSource = this._studentExercisesService.GetStudentExercisesDto();
        }

        private void LoadStudentExercisesForAdmin()
        {
            dgwStudentExercises.DataSource = this._studentExercisesService.GetAll();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            CheckDataSourceForLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var cells = dgwStudentExercises.CurrentRow?.Cells;
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            updateForm.Id = (int)cells[0].Value;
            updateForm.StudentId = (int)cells[1].Value;
            updateForm.ExerciseId = (int)cells[2].Value;
            updateForm.Active = (bool)cells[3].Value;
            updateForm.Show();
            CheckDataSourceForLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Selected student&exercise will be deleted.",
                Ok = DeleteStudentExercise,
                Cancel = Cancel
            });
            CheckDataSourceForLoad();
        }

        private void DeleteStudentExercise()
        {
            _studentExercisesService.Delete(new StudentExercises
            {
                Id = (int)dgwStudentExercises.CurrentRow?.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = InstanceFactory.GetInstance<Search>(new FormModule());
            searchForm.Form = this;
            searchForm.IsUser = this._isUser;
            searchForm.LoadStudentExercises = this.CheckDataSourceForLoad;
            searchForm.DgwStudentExercises = this.dgwStudentExercises;
            searchForm.Show();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            this._studentExercisesService.DeleteAll();
            CheckDataSourceForLoad();
        }

        private void btnChangeDgw_Click(object sender, EventArgs e)
        {
            CheckDataSourceForLoad();
        }

        private void CheckDataSourceForLoad()
        {
            if (this._isUser)
            {
                LoadStudentExercisesForUser();
                btnChangeDgw.Text = @"User";
            }
            else
            {
                LoadStudentExercisesForAdmin();
                btnChangeDgw.Text = @"Admin";
            }
            this._isUser = !this._isUser;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    }
}
