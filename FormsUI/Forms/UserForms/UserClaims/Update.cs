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
    public partial class Update : Form
    {
        private readonly IUserClaimService _userClaimService;

        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClaimId { get; set; }

        public Update()
        {
            InitializeComponent();
            this._userClaimService = InstanceFactory
                .GetInstance<IUserClaimService>(new INinjectModule[] { new CoreModule(), new FormModule() });
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.tbxUserId.Text = this.UserId.ToString();
            this.tbxClaimId.Text = this.ClaimId.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = CoreMessages.Caption,
                Title = CoreMessages.UserClaimUpdate,
                Ok = this.UpdateUserClaim,
                Cancel = this.Cancel
            });
        }

        private void UpdateUserClaim()
        {
            this._userClaimService.Update(new UserClaim
            {
                Id = this.Id,
                UserId = int.Parse(this.tbxUserId.Text),
                ClaimId = int.Parse(this.tbxClaimId.Text)
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
