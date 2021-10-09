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
using Business.Constants;
using FormsUI.Utilities;
using Core.Utilities.Constants;

namespace FormsUI.Forms.UserForms.Users
{
    public partial class UserForm : Form
    {
        private readonly IUserService _userService;
        public User CurrentUser { get; set; }
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
           //MainHelper.GetExistenceCurrentRow(dgwUsers, () =>
           //{
            var cells = this.dgwUsers.CurrentRow?.Cells;
               var passDetails = this._userService.GetPassDetailsById((int)cells[0].Value);
               var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
               updateForm.Id = (int)cells[0].Value;
               updateForm.FirstName = cells[2].Value.ToString();
               updateForm.LastName = cells[3].Value.ToString();
               updateForm.Email = cells[4].Value.ToString();
               updateForm.PasswordHash = passDetails.PasswordHash;
               updateForm.UserName = cells[1].Value.ToString();
               updateForm.Status = (bool)cells[7].Value;
               updateForm.PasswordSalt = passDetails.PasswordSalt;
           //},Messages.CheckRowSelectedOrExists);

          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwUsers, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = "System",
                    Title = "Selected user will be deleted",
                    Ok = DeleteUser,
                    Cancel = Cancel
                });
            },Messages.CheckRowSelectedOrExists);
           
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

            MainHelper.GetExistenceCurrentRow(dgwUsers, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = "System",
                    Title = "All data will be deleted",
                    Ok = DeleteAll,
                    Cancel = Cancel
                });
            },Messages.CheckRowExists);
           
        }

        private void DeleteAll()
        {
            this._userService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadUsers();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwUsers, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = "Do you want to ban the user?",
                    Ok = BanUser,
                    Cancel = Cancel
                });
            }, Messages.CheckRowExists);
           
        }

        private void BanUser()
        {
            var userToBan=new User
            {
                Id = (int)dgwUsers.CurrentRow.Cells[0].Value,
                Email = dgwUsers.CurrentRow.Cells[5].Value.ToString(),
                FirstName = dgwUsers.CurrentRow.Cells[3].Value.ToString(),
                LastName = dgwUsers.CurrentRow.Cells[4].Value.ToString(),
                UserName = dgwUsers.CurrentRow.Cells[2].Value.ToString(),
                PasswordHash = dgwUsers.CurrentRow.Cells[6].Value.ToString(),
                PasswordSalt = dgwUsers.CurrentRow.Cells[7].Value.ToString(),
                Status=false
            };
            var result = _userService.BanUser(CurrentUser, userToBan);
            if (result)
            {
                MainHelper.GetExistenceCurrentRow(dgwUsers, () =>
                {
                    WarnMessageBox.MessageBox.Execute( new MessageBoxParameter 
                    { 
                        Caption=CoreMessages.Caption,
                        Title="Selected user banned successfully!"
                    });
                }, Messages.CheckRowExists);
            }
            else
            {
                MainHelper.GetExistenceCurrentRow(dgwUsers, () =>
                {
                    WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
                    {
                        Caption = CoreMessages.Caption,
                        Title = "Process failed!"
                    });
                }, Messages.CheckRowExists);
            }
        }
    }
}
