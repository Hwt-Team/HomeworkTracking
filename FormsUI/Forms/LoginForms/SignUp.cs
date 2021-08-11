using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Dtos;
using Entities.Dtos;
using FontAwesome.Sharp;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MainMenu;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.LoginForms
{
    public partial class SignUp : Form
    {
        private readonly IUserService _userService;
        public SignUp()
        {
            InitializeComponent();
            this._userService = InstanceFactory.GetInstance<IUserService>(new BusinessModule());
        }

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

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);


        #endregion

        #region MouseDown

        private void lblSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        #endregion

        #region Enter & Leave

        private void tbxUserName_Enter(object sender, EventArgs e)
        {
            if (this.tbxUserName.Text == "Username")
            {
                this.tbxUserName.Text = "";
                this.tbxUserName.ForeColor = Color.Gainsboro;
            }
        }

        private void tbxUserName_Leave(object sender, EventArgs e)
        {
            if (this.tbxUserName.Text == "")
            {
                this.tbxUserName.Text = "Username";
                this.tbxUserName.ForeColor = Color.DarkGray;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (this.tbxPassword.Text == "Password")
            {
                this.tbxPassword.Text = "";
                this.tbxPassword.ForeColor = Color.Gainsboro;
                this.tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (this.tbxPassword.Text == "")
            {
                this.tbxPassword.Text = "Password";
                this.tbxPassword.ForeColor = Color.DarkGray;
                this.tbxPassword.UseSystemPasswordChar = false;
            }
        }

        private void tbxPasswordRepeat_Enter(object sender, EventArgs e)
        {
            if (this.tbxPasswordRepeat.Text == "Password Repeat")
            {
                this.tbxPasswordRepeat.Text = "";
                this.tbxPasswordRepeat.ForeColor = Color.Gainsboro;
                this.tbxPasswordRepeat.UseSystemPasswordChar = true;
            }
        }

        private void tbxPasswordRepeat_Leave(object sender, EventArgs e)
        {
            if (this.tbxPasswordRepeat.Text == "")
            {
                this.tbxPasswordRepeat.Text = "Password Repeat";
                this.tbxPasswordRepeat.ForeColor = Color.DarkGray;
                this.tbxPasswordRepeat.UseSystemPasswordChar = false;
            }
        }

        private void tbxEmail_Enter(object sender, EventArgs e)
        {
            if (this.tbxEmail.Text == "Email")
            {
                this.tbxEmail.Text = "";
                this.tbxEmail.ForeColor = Color.Gainsboro;
            }
        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            if (this.tbxEmail.Text == "")
            {
                this.tbxEmail.Text = "Email";
                this.tbxEmail.ForeColor = Color.DarkGray;
            }
        }

        private void tbxFirstName_Enter(object sender, EventArgs e)
        {
            if (this.tbxFirstName.Text == "Firstname")
            {
                this.tbxFirstName.Text = "";
                this.tbxFirstName.ForeColor = Color.Gainsboro;
            }
        }

        private void tbxFirstName_Leave(object sender, EventArgs e)
        {
            if (this.tbxFirstName.Text == "")
            {
                this.tbxFirstName.Text = "Firstname";
                this.tbxFirstName.ForeColor = Color.DarkGray;
            }
        }

        private void tbxLastName_Enter(object sender, EventArgs e)
        {
            if (this.tbxLastName.Text == "Lastname")
            {
                this.tbxLastName.Text = "";
                this.tbxLastName.ForeColor = Color.Gainsboro;
            }
        }

        private void tbxLastName_Leave(object sender, EventArgs e)
        {
            if (this.tbxLastName.Text == "")
            {
                this.tbxLastName.Text = "Lastname";
                this.tbxLastName.ForeColor = Color.DarkGray;
            }
        }

        #endregion

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //var message = "Please, enter ";
            //if (this.tbxUserName.Text != "Username")
            //{
            //    if (this.tbxPassword.Text != "Password")
            //    {
            //        if (this.tbxPasswordRepeat.Text != "Password Repeat")
            //        {
            //            if (this.tbxEmail.Text != "Email")
            //            {
            //                if (this.tbxFirstName.Text != "Firstname")
            //                {
            //                    if (this.tbxLastName.Text != "Lastname")
            //                    {
            //                        this.lblErrorMessage.Visible = false;
            //                        this._userService.Register(new UserRegisterDto
            //                        {
            //                            UserName = this.tbxUserName.Text,
            //                            Password = this.tbxPassword.Text,
            //                            PasswordRepeat = this.tbxPasswordRepeat.Text,
            //                            FirstName = this.tbxFirstName.Text,
            //                            LastName = this.tbxLastName.Text,
            //                            Email = this.tbxEmail.Text
            //                        });

            //                        WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
            //                        {
            //                            Caption = "System",
            //                            Title = "Register successfully!"
            //                        });
            //                    }
            //                    else
            //                    {
            //                        SetErrorMessage(message + "lastname.");
            //                    }
            //                }
            //                else
            //                {
            //                    SetErrorMessage(message + "firstname.");
            //                }
            //            }
            //            else
            //            {
            //                SetErrorMessage(message + "email");
            //            }
            //        }
            //        else
            //        {
            //            SetErrorMessage(message + "password repeat.");
            //        }
            //    }
            //    else
            //    {
            //        SetErrorMessage(message + "password.");
            //    }
            //}
            //else
            //{
            //    SetErrorMessage(message + "username.");
            //}

            var validation = ValidateHelper.ValidateAll(
                this.tbxPassword.Text,
                this.tbxPasswordRepeat.Text,
                "Password and repeat are not the same.",
                this.lblErrorMessage,
                new ValidationModel
                {
                    CurrentText = this.tbxUserName.Text,
                    PreviousText = "Username",
                    Message = "username"
                },
                new ValidationModel
                {
                    CurrentText = this.tbxPassword.Text,
                    PreviousText = "Password",
                    Message = "password"
                },
                new ValidationModel
                {
                    CurrentText = this.tbxPasswordRepeat.Text,
                    PreviousText = "Password Repeat",
                    Message = "password repeat"
                },
                new ValidationModel
                {
                    CurrentText = this.tbxEmail.Text,
                    PreviousText = "Email",
                    Message = "email"
                },
                new ValidationModel
                {
                    CurrentText = this.tbxFirstName.Text,
                    PreviousText = "Firstname",
                    Message = "firstname"
                },
                new ValidationModel
                {
                    CurrentText = this.tbxLastName.Text,
                    PreviousText = "Lastname",
                    Message = "lastname"
                });

            if (validation)
            {
                ExceptionHandler.Handle(() =>
                {
                    this._userService.Register(new UserRegisterDto
                    {
                        UserName = this.tbxUserName.Text,
                        Password = this.tbxPassword.Text,
                        PasswordRepeat = this.tbxPasswordRepeat.Text,
                        FirstName = this.tbxFirstName.Text,
                        LastName = this.tbxLastName.Text,
                        Email = this.tbxEmail.Text
                    });
                    WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
                    {
                        Caption = "System",
                        Title = "Register successfully!"
                    });

                    this.OpenBaseForm();
                });
                                
            }
        }

        private void OpenBaseForm()
        {
            var form = InstanceFactory.GetInstance<BaseForm>(new FormModule());
            this.Close();
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var loginForm = InstanceFactory.GetInstance<Login>(new FormModule());
            this.Close();
            loginForm.Show();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            this.btnBack.IconColor = Color.DarkGray;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            this.btnBack.IconColor = Color.Gainsboro;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnPassVisibility_Click(object sender, EventArgs e)
        {
            if (this.tbxPassword.Text == "Password" | this.tbxPassword.Text == "") return;
            this.tbxPassword.UseSystemPasswordChar = !this.tbxPassword.UseSystemPasswordChar;
            SetPasswordChar(this.tbxPassword, !this.tbxPassword.UseSystemPasswordChar);
            SetIcon(this.btnPassVisibility, !this.tbxPassword.UseSystemPasswordChar);
        }

        private void btnPassRepeatVisibility_Click(object sender, EventArgs e)
        {
            if (this.tbxPasswordRepeat.Text == "Password Repeat" | this.tbxPasswordRepeat.Text == "") return;
            this.tbxPasswordRepeat.UseSystemPasswordChar = !this.tbxPasswordRepeat.UseSystemPasswordChar;
            SetPasswordChar(this.tbxPasswordRepeat, !this.tbxPasswordRepeat.UseSystemPasswordChar);
            SetIcon(this.btnPassRepeatVisibility, !this.tbxPasswordRepeat.UseSystemPasswordChar);
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
