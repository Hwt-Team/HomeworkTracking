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

namespace FormsUI.Forms.UserForms.Claims.Main
{
    public partial class MainClaimForm : Form
    {
        private readonly IMainClaimService _mainClaimService;

        public MainClaimForm()
        {
            InitializeComponent();
            this._mainClaimService = InstanceFactory
                .GetInstance<IMainClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void MainClaimForm_Load(object sender, EventArgs e)
        {
            this.LoadMainClaims();
            this.DesignDataGridView(this.dgwMainClaims);
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

        private void LoadMainClaims()
        {
            this.dgwMainClaims.DataSource = this._mainClaimService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            this.LoadMainClaims();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            var cells = this.dgwMainClaims.CurrentRow?.Cells;
            updateForm.Id = (int)cells[0].Value;
            updateForm.Name = cells[1].Value.ToString();
            updateForm.Show();
            this.LoadMainClaims();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = CoreMessages.Caption,
                Title = CoreMessages.MainClaimDelete,
                Ok = this.DeleteMainClaim,
                Cancel = this.Cancel
            });
        }

        private void DeleteMainClaim()
        {
            this._mainClaimService.Delete(new MainClaim
            {
                Id = (int)this.dgwMainClaims.CurrentRow?.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = CoreMessages.Caption,
                Title = CoreMessages.MainClaimDeleteAll,
                Ok = this.DeleteAll,
                Cancel = this.Cancel
            });
        }

        private void DeleteAll()
        {
            this._mainClaimService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadMainClaims();
        }
    }
}
