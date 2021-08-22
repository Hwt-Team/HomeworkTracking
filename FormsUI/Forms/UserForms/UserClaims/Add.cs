using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;
using Ninject.Modules;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.UserClaims
{
    public partial class Add : Form
    {
        private readonly IUserClaimService _userClaimService;
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        public Add()
        {
            InitializeComponent();
            this._userClaimService = InstanceFactory
                .GetInstance<IUserClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
            MainHelper.SetHelperFormName(panelUserClaimAdd, label);
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

        private void panelUserClaimAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
