using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Constants;
using FormsUI.Utilities;

namespace FormsUI.Forms.UserForms.ProjectObjectClaims
{
    public partial class ProjectObjectClaimForm : Form
    {
        private readonly IProjectObjectClaimService _projectObjectClaimService;
        private bool _isUser = false;

        public ProjectObjectClaimForm()
        {
            InitializeComponent();
            this._projectObjectClaimService = InstanceFactory
                .GetInstance<IProjectObjectClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void ProjectObjectClaimForm_Load(object sender, EventArgs e)
        {
            this.DesignDataGridView(this.dgwProjectObjectClaims);
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
            this.dgwProjectObjectClaims.DataSource = this._projectObjectClaimService;
        }

        private void LoadUserClaimsForAdmin()
        {
            this.dgwProjectObjectClaims.DataSource = this._projectObjectClaimService.GetAll();
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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwProjectObjectClaims, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = CoreMessages.ProjectObjectClaimDelete,
                    Ok = this.DeleteProjectObjectClaim,
                    Cancel = this.Cancel
                });
                this.CheckDataSourceForLoad();
            }, Messages.CheckRowSelectedOrExists);
           
        }

        private void DeleteProjectObjectClaim()
        {
            this._projectObjectClaimService.Delete(new ProjectObjectClaim
            {
                Id = (int)this.dgwProjectObjectClaims.CurrentRow?.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwProjectObjectClaims, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = CoreMessages.ProjectObjectClaimDeleteAll,
                    Ok = this.DeleteAll,
                    Cancel = this.Cancel
                });
                this.CheckDataSourceForLoad();
            },Messages.CheckRowExists);
            
        }

        private void DeleteAll()
        {
            this._projectObjectClaimService.DeleteAll();
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
