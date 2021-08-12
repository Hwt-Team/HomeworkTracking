using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.ProjectObjects
{
    public partial class ProjectObjectForm : Form
    {
        private readonly IProjectObjectService _projectObjectService;
        public ProjectObjectForm()
        {
            InitializeComponent();
            this._projectObjectService = InstanceFactory
                .GetInstance<IProjectObjectService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void ProjectObjectForm_Load(object sender, EventArgs e)
        {
            this.LoadProjectObjects();
            this.DesignDataGridView(this.dgwProjectObjects);
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

        private void LoadProjectObjects()
        {
            this.dgwProjectObjects.DataSource = this._projectObjectService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            this.LoadProjectObjects();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!this.GetExistenceCurrentRow())
            {
                WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
                {
                    Caption = "System",
                    Title = "Any line did not selected or no line."
                });
                return;
            }

            var cells = this.dgwProjectObjects.CurrentRow?.Cells;
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            updateForm.Id = (int)cells[0].Value;
            updateForm.Namespace = cells[1].Value.ToString();
            updateForm.ClassName = cells[2].Value.ToString();
            updateForm.ObjectName = cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!this.GetExistenceCurrentRow())
            {
                WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
                {
                    Caption = "System",
                    Title = "Any line did not selected or no line."
                });
                return;
            }

            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Selected project object will be deleted",
                Ok = DeleteProjectObject,
                Cancel = Cancel
            });
        }

        private void DeleteProjectObject()
        {
            this._projectObjectService.Delete(new ProjectObject
            {
                Id = (int)this.dgwProjectObjects.CurrentRow.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (!this.GetExistenceCurrentRow())
            {
                WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
                {
                    Caption = "System",
                    Title = "No line to delete."
                });
                return;
            }

            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "All data will be deleted",
                Ok = DeleteAll,
                Cancel = Cancel
            });
        }

        private void DeleteAll()
        {
            this._projectObjectService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadProjectObjects();
        }

        private bool GetExistenceCurrentRow()
        {
            return this.dgwProjectObjects.CurrentRow != null;
        }
    }
}
