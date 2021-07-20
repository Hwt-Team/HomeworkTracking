using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentForms.Studies
{
    public partial class StudiesForm : Form
    {
        private readonly IStudyingStudentService _studyingStudentService;
        public StudiesForm()
        {
            InitializeComponent();
            this._studyingStudentService = InstanceFactory
                .GetInstance<IStudyingStudentService>(new BusinessModule());
        }

        private void GraduateForm_Load(object sender, EventArgs e)
        {
            LoadStudies();
            DesignDataGridView(dgwStudies);
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

        private void LoadStudies()
        {
            this.dgwStudies.DataSource = this._studyingStudentService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadStudies();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            var cells = this.dgwStudies.CurrentRow?.Cells;
            updateForm.Id = (int) cells[0].Value;
            updateForm.FirstName = cells[1].Value.ToString();
            updateForm.LastName = cells[2].Value.ToString();
            updateForm.GroupId = (int) cells[3].Value;
            updateForm.Show();
            LoadStudies();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Selected graduate will be deleted.",
                Ok = DeleteStudying,
                Cancel = Cancel
            });
        }

        private void DeleteStudying()
        {
            this._studyingStudentService.Delete(new StudyingStudent
            {
                Id = (int) dgwStudies.CurrentRow.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "All data will be deleted.",
                Ok = DeleteAll,
                Cancel = Cancel
            });
        }

        private void DeleteAll()
        {
            this._studyingStudentService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadStudies();
        }
    }
}
