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
    public partial class Add : Form
    {
        private IStateService _stateService;
        public Add()
        {
            InitializeComponent();
            this._stateService = InstanceFactory.GetInstance<IStateService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelStateAdd, label);
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
                Caption = "System",
                Title = "A new state will be added.",
                Ok = AddState,
                Cancel = Cancel
            });
        }

        private void AddState()
        {
            this._stateService.Add(new State
            {
                Id = this._stateService.GetNextId(),
                Name = tbxName.Text
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelStateAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
