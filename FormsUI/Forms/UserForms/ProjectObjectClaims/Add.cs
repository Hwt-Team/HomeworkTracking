using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.ProjectObjectClaims
{
    public partial class Add : Form
    {
        private readonly IProjectObjectClaimService _projectObjectClaimService;


        public Add()
        {
            InitializeComponent();
            this._projectObjectClaimService = InstanceFactory
                .GetInstance<IProjectObjectClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = CoreMessages.Caption,
                Title = CoreMessages.ProjectObjectClaimAdd,
                Ok = this.AddProjectObjectClaim,
                Cancel = this.Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel() { }

        private void AddProjectObjectClaim()
        {
            this._projectObjectClaimService.Add(new ProjectObjectClaim
            {
                Id = this._projectObjectClaimService.GetNextId(),
                SubsidiaryClaimId = int.Parse(this.tbxSubsidiaryClaimId.Text),
                ProjectObjectId = int.Parse(this.tbxProjectObjectId.Text)
            });
        }

        private void panelProjectObjectClaimsAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
