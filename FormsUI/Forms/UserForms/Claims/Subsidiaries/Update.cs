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

namespace FormsUI.Forms.UserForms.Claims.Subsidiaries
{
    public partial class Update : Form
    {
        private readonly ISubsidiaryClaimService _subsidiaryClaimService;

        public int Id { get; set; }
        public string ClaimName { get; set; }

        public Update()
        {
            InitializeComponent();
            this._subsidiaryClaimService = InstanceFactory
                .GetInstance<ISubsidiaryClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.tbxName.Text = this.ClaimName;
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
                Title = CoreMessages.SubsidiaryClaimUpdate,
                Ok = this.UpdateSubsidiaryClaim,
                Cancel = this.Cancel
            });
        }

        private void UpdateSubsidiaryClaim()
        {
            this._subsidiaryClaimService.Update(new SubsidiaryClaim
            {
                Id = this.Id,
                Name = this.tbxName.Text
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSubsidiaryClaimUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
