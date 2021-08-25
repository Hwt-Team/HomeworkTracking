using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.StateForms
{
    public partial class Update : Form
    {
        private IStateService _stateService;
        public int Id { get; set; }
        public string StateName { get; set; }
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion
        public Update()
        {
            InitializeComponent();
            this._stateService = InstanceFactory.GetInstance<IStateService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelStateUpdate, label);
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

        private void panelStateUpdate_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
