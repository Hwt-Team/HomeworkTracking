using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;
using Ninject.Modules;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.Users
{
    public partial class Add : Form
    {
        private readonly IUserService _userService;
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion
        public Add()
        {
            InitializeComponent();
            this._userService = InstanceFactory
                .GetInstance<IUserService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
            MainHelper.SetHelperFormName(panelUserAdd, label);
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new user will be added.",
                Ok = this.AddUser,
                Cancel = this.Cancel
            });
        }

        private void AddUser()
        {
            var result = this._userService.HashPassword(this.tbxPassword.Text);
            
            this._userService.Add(new User
            {
                Id = this._userService.GetNextId(),
                UserName = this.tbxUserName.Text,
                Email = this.tbxEmail.Text,
                FirstName = this.tbxFirstName.Text,
                LastName = this.tbxLastName.Text,
                Status = this.cbxStatus.Checked,
                PasswordHash = result.PasswordHash,
                PasswordSalt = result.PasswordSalt
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelUserAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
