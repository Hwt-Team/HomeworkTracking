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

namespace FormsUI.Forms.UserForms.Claims.Main
{
    public partial class Update : Form
    {
        private readonly IMainClaimService _mainClaimService;

        public int Id { get; set; }
        public string ClaimName { get; set; }
        public int Priority { get; set; }


        public Update()
        {
            InitializeComponent();
            this._mainClaimService = InstanceFactory
                .GetInstance<IMainClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.tbxName.Text = this.ClaimName;
            this.tbxPriority.Text = this.Priority.ToString();
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
                Title = CoreMessages.MainClaimUpdate,
                Ok = this.UpdateMainClaim,
                Cancel = this.Cancel
            });
        }

        private void UpdateMainClaim()
        {
            this._mainClaimService.Update(new MainClaim
            {
                Id = this.Id,
                Name = this.tbxName.Text,
                Priority = int.Parse(this.tbxPriority.Text)
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMainClaimUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
