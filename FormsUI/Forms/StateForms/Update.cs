using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StateForms
{
    public partial class Update : Form
    {
        private IStateService _stateService;
        public int Id { get; set; }
        public string StateName { get; set; }
        public Update()
        {
            InitializeComponent();
            this._stateService = InstanceFactory.GetInstance<IStateService>(new BusinessModule());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Changed state will be updated.",
                Ok = UpdateState,
                Cancel = Cancel
            });
        }

        private void UpdateState()
        {
            this._stateService.Update(new State
            {
                Id = this.Id,
                Name = tbxName.Text
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            tbxName.Text = this.StateName;
        }
    }
}
