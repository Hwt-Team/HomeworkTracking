using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Business.Constants;
using FormsUI.Utilities;

namespace FormsUI.Forms.UserForms.UserClaims
{
    public partial class UserClaimForm : Form
    {
        private readonly IUserClaimService _userClaimService;
        private bool _isUser = false;

        public UserClaimForm()
        {
            InitializeComponent();
            this._userClaimService = InstanceFactory
                .GetInstance<IUserClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void UserClaimForm_Load(object sender, EventArgs e)
        {
            this.CheckDataSourceForLoad();
            this.DesignDataGridView(this.dgwUserClaims);
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

        private void LoadUserClaimsForUser()
        {
            this.dgwUserClaims.DataSource = this._userClaimService.GetUserClaimDto();
        }

        private void LoadUserClaimsForAdmin()
        {
            this.dgwUserClaims.DataSource = this._userClaimService.GetAll();
        }

        private void CheckDataSourceForLoad()
        {
            if (this._isUser)
            {
                LoadUserClaimsForUser();
                btnChangeDgw.Text = @"User";
            }
            else
            {
                LoadUserClaimsForAdmin();
                btnChangeDgw.Text = @"Admin";
            }
            this._isUser = !this._isUser;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            this.CheckDataSourceForLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwUserClaims, () =>
            {
                var cells = this.dgwUserClaims.CurrentRow?.Cells;
                var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
                updateForm.Id = (int)cells[0].Value;
                updateForm.UserId = (int)cells[1].Value;
                updateForm.ClaimId = (int)cells[2].Value;
                updateForm.Show();
                this.CheckDataSourceForLoad();
            }, Messages.CheckRowSelectedOrExists);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwUserClaims, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = CoreMessages.UserClaimAdd,
                    Ok = this.DeleteUserClaim,
                    Cancel = this.Cancel
                });
                this.CheckDataSourceForLoad();
            }, Messages.CheckRowSelectedOrExists);
            
        }

        private void DeleteUserClaim()
        {
            this._userClaimService.Delete(new UserClaim
            {
                Id = (int)this.dgwUserClaims.CurrentRow?.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwUserClaims, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = CoreMessages.UserClaimDeleteAll,
                    Ok = this.DeleteAll,
                    Cancel = this.Cancel
                });
                this.CheckDataSourceForLoad();
            }, Messages.CheckRowExists);
           
        }

        private void DeleteAll()
        {
            this._userClaimService.DeleteAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeDgw_Click(object sender, EventArgs e)
        {
            this.CheckDataSourceForLoad();
        }
    }
}
