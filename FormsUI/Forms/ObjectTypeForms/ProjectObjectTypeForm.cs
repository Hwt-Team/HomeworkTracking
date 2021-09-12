using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Business.Constants;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.ObjectTypeForms
{
    public partial class ProjectObjectTypeForm : Form
    {
        private readonly IProjectObjectTypeService _projectObjectTypeService;

        public ProjectObjectTypeForm()
        {
            InitializeComponent();
            this._projectObjectTypeService = InstanceFactory.GetInstance<IProjectObjectTypeService>(new BusinessModule());
        }

        private void StateForm_Load(object sender, EventArgs e)
        {
            LoadProjectObjectTypes();
            DesignDataGridView(dgwProjectObjectType);
            //this.dgwStates.BackColor = Color.Transparent;
            //this.dgwStates.BackgroundColor = Color.Transparent;
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

        private void LoadProjectObjectTypes()
        {
            dgwProjectObjectType.DataSource = this._projectObjectTypeService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadProjectObjectTypes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwProjectObjectType, () =>
            {
                var cells = this.dgwProjectObjectType.CurrentRow?.Cells;
                var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
                updateForm.Id = (int)cells[0].Value;
                updateForm.ObjectTypeName = cells[1].Value.ToString();
                updateForm.Show();
                LoadProjectObjectTypes();
            },Messages.CheckRowSelectedOrExists);
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwProjectObjectType, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = "System",
                    Title = "Selected state will be deleted.",
                    Ok = DeleteObjectType,
                    Cancel = Cancel
                });
            }, Messages.CheckRowSelectedOrExists);
           
        }

        private void DeleteObjectType()
        {
            this._projectObjectTypeService.Delete(new ProjectObjectType
            {
                Id = (int) dgwProjectObjectType.CurrentRow?.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwProjectObjectType, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = "System",
                    Title = "All data will be deleted.",
                    Ok = DeleteAll,
                    Cancel = Cancel
                });
                LoadProjectObjectTypes();
            }, Messages.CheckRowExists);
           
        }

        private void DeleteAll()
        {
            this._projectObjectTypeService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
           LoadProjectObjectTypes();
        }
    }
}
