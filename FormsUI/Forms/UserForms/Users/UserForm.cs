using Business.Abstract;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.Forms.MessageBox;
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
                .GetInstance<IUserService>(new CoreModule());
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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
    }
}
