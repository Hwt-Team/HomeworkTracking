using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Utilities.Constants;
using FontAwesome.Sharp;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MainMenu;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;
using Ninject.Modules;

namespace FormsUI.Forms.LoginForms
{
    public partial class Login : Form
    {
        private readonly IUserService _userService;

        public User User { get; set; }
        public string Pass { get; set; }

        public Login()
        {
            InitializeComponent();
            this._userService = InstanceFactory.GetInstance<IUserService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });

            if (this.User != null)
            {
                this.tbxUserName.Text = this.User.UserName;
                this.tbxPassword.Text = this.Pass;
            }
        }

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);


        #endregion

        #region MouseDown

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Window

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Enter & Leave

        private void tbxUserName_Enter(object sender, EventArgs e)
        {
            if (tbxUserName.Text == "Username or Email")
            {
                tbxUserName.Text = "";
                tbxUserName.ForeColor = Color.Gainsboro;
            }
        }

        private void tbxUserName_Leave(object sender, EventArgs e)
        {
            if (tbxUserName.Text == "")
            {
                tbxUserName.Text = "Username or Email";
                tbxUserName.ForeColor = Color.DarkGray;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "Password")
            {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = Color.Gainsboro;
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                tbxPassword.Text = "Password";
                tbxPassword.ForeColor = Color.DarkGray;
                tbxPassword.UseSystemPasswordChar = false;
            }
        }



        #endregion

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var validation = ValidateHelper.ChangedValidation(
                this.lblErrorMessage,
                new ValidationModel
                {
                    CurrentText = this.tbxUserName.Text,
                    PreviousText = "Username or Email",
                    Message = "username or email"
                },
                new ValidationModel
                {
                    CurrentText = this.tbxPassword.Text,
                    PreviousText = "Password",
                    Message = "password"
                });

            if (validation)
            {
                ExceptionHandler.Handle(() =>
                {
                    this._userService.Login(new UserLoginDto
                    {
                        EmailOrUsername = this.tbxUserName.Text,
                        Password = this.tbxPassword.Text
                    });

                    WarnMessageBox.MessageBox.ExecuteAsDialog(new MessageBoxParameter
                    {
                        Caption = CoreMessages.Caption,
                        Title = CoreMessages.LoginSuccess
                    });

                    this.OpenBaseForm(this.tbxUserName.Text);
                });
            }
        }

        private void OpenBaseForm(string email)
        {
            var form = InstanceFactory.GetInstance<BaseForm>(new FormModule());
            this.Hide();
            form.User = this._userService.GetByEmailOrUserName(email);
            form.Show();
        }

        private void linkLblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signUpForm = InstanceFactory.GetInstance<SignUp>(new FormModule());
            this.Hide();
            signUpForm.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPassVisibility_Click(object sender, EventArgs e)
        {
            if (this.tbxPassword.Text == "Password" | this.tbxPassword.Text == "") return;
            this.tbxPassword.UseSystemPasswordChar = !this.tbxPassword.UseSystemPasswordChar;
            SetPasswordChar(this.tbxPassword, !this.tbxPassword.UseSystemPasswordChar);
            SetIcon(this.btnPassVisibility, !this.tbxPassword.UseSystemPasswordChar);
        }

        private void SetPasswordChar(TextBox textBox, bool spChar)
        {
            if (spChar) textBox.UseSystemPasswordChar = false;
            else textBox.UseSystemPasswordChar = true;
        }

        private void SetIcon(IconButton button, bool spChar)
        {
            if (spChar) button.IconChar = IconChar.Eye;
            else button.IconChar = IconChar.EyeSlash;
        }
    }
}
