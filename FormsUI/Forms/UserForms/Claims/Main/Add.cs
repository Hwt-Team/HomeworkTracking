using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;
using Ninject.Modules;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.Claims.Main
{
    public partial class Add : Form
    {
        private readonly IMainClaimService _mainClaimService;

        public Add()
        {
            InitializeComponent();
            this._mainClaimService = InstanceFactory
                .GetInstance<IMainClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void Add_Load(object sender, EventArgs e)
        {
            MainHelper.SetHelperFormName(this.panelMainClaimAdd, this.label);
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
                Title = CoreMessages.MainClaimAdd,
                Ok = this.AddMainClaim,
                Cancel = this.Cancel
            });
        }

        private void Cancel() { }

        private void AddMainClaim()
        {
            this._mainClaimService.Add(new MainClaim
            {
                Id = this._mainClaimService.GetNextId(),
                Name = this.tbxName.Text,
                Priority = int.Parse(this.tbxPriority.Text)
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMainClaimAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
