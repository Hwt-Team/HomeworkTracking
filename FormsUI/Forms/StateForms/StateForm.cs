using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StateForms
{
    public partial class StateForm : Form
    {
        private IStateService _stateService;

        public StateForm()
        {
            InitializeComponent();
            this._stateService = InstanceFactory.GetInstance<IStateService>(new BusinessModule());
        }

        private void StateForm_Load(object sender, EventArgs e)
        {
            LoadStates();
        }

        private void LoadStates()
        {
            dgwStates.DataSource = this._stateService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadStates();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var cells = this.dgwStates.CurrentRow?.Cells;
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            updateForm.Id = (int) cells[0].Value;
            updateForm.StateName = cells[1].Value.ToString();
            updateForm.Show();
            LoadStates();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Selected state will be deleted.",
                Ok = DeleteState,
                Cancel = Cancel
            });
        }

        private void DeleteState()
        {
            this._stateService.Delete(new State
            {
                Id = (int) dgwStates.CurrentRow?.Cells[0].Value
            });
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "All data will be deleted.",
                Ok = DeleteAll,
                Cancel = Cancel
            });
            LoadStates();
        }

        private void DeleteAll()
        {
            this._stateService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadStates();
        }
    }
}
