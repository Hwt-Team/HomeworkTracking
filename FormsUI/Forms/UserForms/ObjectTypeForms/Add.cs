using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;
using Core.Entities.Concrete;

namespace FormsUI.Forms.UserForms.ObjectTypeForms
{
    public partial class Add : Form
    {
        private readonly IProjectObjectTypeService _projectObjectTypeService;
        public Add()
        {
            InitializeComponent();
            this._projectObjectTypeService = InstanceFactory.GetInstance<IProjectObjectTypeService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelProjectObjectTypeAdd, label);
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
            this._projectObjectTypeService.Add(new ProjectObjectType
            {
                Id = this._projectObjectTypeService.GetNextId(),
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
