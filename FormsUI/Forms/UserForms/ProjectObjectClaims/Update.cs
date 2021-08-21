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
    public partial class Update : Form
    {
        private readonly IProjectObjectClaimService _projectObjectClaimService;

        public int Id { get; set; }
        public int SubsidiaryClaimId { get; set; }
        public int ProjectObjectClaimId { get; set; }

        public Update()
        {
            InitializeComponent();
            this._projectObjectClaimService = InstanceFactory
                .GetInstance<IProjectObjectClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.tbxProjectObjectId.Text = this.ProjectObjectClaimId.ToString();
            this.tbxSubsidiaryClaimId.Text = this.SubsidiaryClaimId.ToString();
        }

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = CoreMessages.Caption,
                Title = CoreMessages.ProjectObjectClaimUpdate,
                Ok = this.UpdateProjectObjectClaim,
                Cancel = this.Cancel
            });
        }

        private void UpdateProjectObjectClaim()
        {
            this._projectObjectClaimService.Update(new ProjectObjectClaim
            {
                Id = this.Id,
                SubsidiaryClaimId = int.Parse(this.tbxSubsidiaryClaimId.Text),
                ProjectObjectId = int.Parse(this.tbxProjectObjectId.Text)
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelProjectObjectClaimsUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
