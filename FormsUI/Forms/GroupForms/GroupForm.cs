using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Business.Constants;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.GroupForms
{
    public partial class GroupForm : Form
    {
        private IGroupService _groupService;
        private int _id;
        public GroupForm()
        {
            InitializeComponent();
            this._groupService = InstanceFactory.GetInstance<IGroupService>(new BusinessModule());
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
            DesignDataGridView(dgwGroups);
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

        public void LoadGroups()
        {
            dgwGroups.DataSource = this._groupService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadGroups();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           MainHelper.GetExistenceCurrentRow(dgwGroups, () =>
           {
               var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
               updateForm.GroupName = this.dgwGroups.CurrentRow?.Cells[1].Value.ToString();
               updateForm.Id = (int)this.dgwGroups.CurrentRow?.Cells[0].Value;
               updateForm.Show();
               LoadGroups();
           },Messages.CheckRowSelectedOrExists);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwGroups, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = "System",
                    Title = "Selected group will be deleted.",
                    Ok = DeleteGroup,
                    Cancel = Cancel
                });
            }, Messages.CheckRowSelectedOrExists);
            
        }

        private void DeleteGroup()
        {
            this._groupService.Delete(new Group
            {
                Id = _id
            });
            LoadGroups();
        }

        private void Cancel()
        {
            //...
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwGroups, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = "System",
                    Title = "All data will be deleted.",
                    Ok = DeleteAll,
                    Cancel = Cancel
                });
                LoadGroups();
            }, Messages.CheckRowExists);
            
        }

        private void DeleteAll()
        {
            this._groupService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void dgwGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._id = (int) dgwGroups.CurrentRow?.Cells[0].Value;
        }
    }
}
