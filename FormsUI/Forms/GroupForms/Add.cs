using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.GroupForms
{
    public partial class Add : Form
    {
        private IGroupService _groupService;

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion
        public Add()
        {
            InitializeComponent();
            this._groupService = InstanceFactory.GetInstance<IGroupService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelGroupAdd, label);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //var messageBox = InstanceFactory.GetInstance<WarnMessageBox>(new FormModule());
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new group will be added.",
                Ok = AddGroup,
                Cancel = Cancel
            });
        }

        private void AddGroup()
        {
            this._groupService.Add(new Group
            {
                Id = this._groupService.GetNextId(),
                Name = tbxName.Text
            });
        }

        private void Cancel()
        {
            //this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelGroupAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Add_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
