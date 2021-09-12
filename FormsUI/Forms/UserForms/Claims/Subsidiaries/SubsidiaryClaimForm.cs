using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Constants;
using FormsUI.Utilities;

namespace FormsUI.Forms.UserForms.Claims.Subsidiaries
{
    public partial class SubsidiaryClaimForm : Form
    {
        private readonly ISubsidiaryClaimService _subsidiaryClaimService;

        public SubsidiaryClaimForm()
        {
            InitializeComponent();
            this._subsidiaryClaimService = InstanceFactory
                .GetInstance<ISubsidiaryClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void SubsidiaryClaimForm_Load(object sender, EventArgs e)
        {
            this.LoadSubsidiaryClaims();
            this.DesignDataGridView(this.dgwSubsidiaryClaims);
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

        private void LoadSubsidiaryClaims()
        {
            this.dgwSubsidiaryClaims.DataSource = this._subsidiaryClaimService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            this.LoadSubsidiaryClaims();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwSubsidiaryClaims, () =>
            {
                var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
                var cells = this.dgwSubsidiaryClaims.CurrentRow?.Cells;
                updateForm.Id = (int)cells[0].Value;
                updateForm.Name = cells[1].Value.ToString();
                updateForm.Show();
                this.LoadSubsidiaryClaims();
            },Messages.CheckRowSelectedOrExists);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwSubsidiaryClaims, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = CoreMessages.SubsidiaryClaimDelete,
                    Ok = this.DeleteSubsidiaryClaim,
                    Cancel = this.Cancel
                });
            }, Messages.CheckRowSelectedOrExists);
           
        }

        private void DeleteSubsidiaryClaim()
        {
            this._subsidiaryClaimService.Delete(new SubsidiaryClaim
            {
                Id = (int)this.dgwSubsidiaryClaims.CurrentRow?.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            MainHelper.GetExistenceCurrentRow(dgwSubsidiaryClaims, () =>
            {
                WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = CoreMessages.SubsidiaryClaimDeleteAll,
                    Ok = this.DeleteAll,
                    Cancel = this.Cancel
                });
            }, Messages.CheckRowExists);
          
        }

        private void DeleteAll()
        {
            this._subsidiaryClaimService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadSubsidiaryClaims();
        }
    }
}
