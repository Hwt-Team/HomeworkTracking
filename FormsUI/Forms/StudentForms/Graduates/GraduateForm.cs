using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentForms.Graduates
{
    public partial class GraduateForm : Form
    {
        private readonly IGraduateStudentService _graduateStudentService;
        public GraduateForm()
        {
            InitializeComponent();
            this._graduateStudentService = InstanceFactory
                .GetInstance<IGraduateStudentService>(new BusinessModule());
        }

        private void GraduateForm_Load(object sender, EventArgs e)
        {
            LoadGraduates();
            DesignDataGridView(dgwGraduates);
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

        private void LoadGraduates()
        {
            this.dgwGraduates.DataSource = this._graduateStudentService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadGraduates();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            var cells = this.dgwGraduates.CurrentRow?.Cells;
            updateForm.Id = (int) cells[0].Value;
            updateForm.FirstName = cells[1].Value.ToString();
            updateForm.LastName = cells[2].Value.ToString();
            updateForm.GroupId = (int) cells[3].Value;
            updateForm.GraduateDate = (DateTime) cells[4].Value;
            updateForm.Show();
            LoadGraduates();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Selected graduate will be deleted.",
                Ok = DeleteGraduate,
                Cancel = Cancel
            });
        }

        private void DeleteGraduate()
        {
            this._graduateStudentService.Delete(new GraduateStudent
            {
                Id = (int) dgwGraduates.CurrentRow.Cells[0].Value
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
            this._graduateStudentService.DeleteAll();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadGraduates();
        }
    }
}
