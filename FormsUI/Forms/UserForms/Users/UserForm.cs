using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.Users
{
    public partial class UserForm : Form
    {
        private readonly IUserService _userService; 
        public UserForm()
        {
            InitializeComponent();
            this._userService = InstanceFactory
                .GetInstance<IUserService>(new INinjectModule[] { new CoreModule(), new BusinessModule()});
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.LoadUsers();
            this.DesignDataGridView(dgwUsers);
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

        private void LoadUsers()
        {
            this.dgwUsers.DataSource = this._userService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadUsers();
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

            var cells = this.dgwUsers.CurrentRow?.Cells;
            var passDetails = this._userService.GetPassDetailsById((int)cells[0].Value);
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            updateForm.Id = (int)cells[0].Value;
            updateForm.FirstName = cells[1].Value.ToString();
            updateForm.LastName = cells[2].Value.ToString();
            updateForm.Email = cells[3].Value.ToString();
            updateForm.PasswordHash = passDetails.PasswordHash;
            updateForm.UserName = cells[5].Value.ToString();
            updateForm.Status = (bool) cells[6].Value;
            updateForm.PasswordSalt = passDetails.PasswordSalt;
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
                Title = "Selected user will be deleted",
                Ok = DeleteUser,
                Cancel = Cancel
            });
        }

        private void DeleteUser()
        {
            this._userService.Delete(new User
            {
                Id = (int)this.dgwUsers.CurrentRow.Cells[0].Value
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
            this._userService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadUsers();
        }

        private bool GetExistenceCurrentRow()
        {
            return this.dgwUsers.CurrentRow != null;
        }
    }
}
