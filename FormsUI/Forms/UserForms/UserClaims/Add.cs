using Business.Abstract;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.UserClaims
{
    public partial class Add : Form
    {
        private readonly IUserClaimService _userClaimService;

        public Add()
        {
            InitializeComponent();
            this._userClaimService = InstanceFactory
                .GetInstance<IUserClaimService>(new INinjectModule[] { new CoreModule(), new FormModule() });
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = CoreMessages.Caption,
                Title = CoreMessages.UserClaimAdd,
                Ok = this.AddUserClaim,
                Cancel = this.Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel() { }

        private void AddUserClaim()
        {
            this._userClaimService.Add(new UserClaim
            {
                Id = this._userClaimService.GetNextId(),
                UserId = int.Parse(this.tbxUserId.Text),
                ClaimId = int.Parse(this.tbxClaimId.Text)
            });
        }

    }
}
