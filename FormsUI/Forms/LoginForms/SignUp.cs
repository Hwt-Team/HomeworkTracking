using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DependencyResolvers.Ninject;
using FormsUI.DependencyResolvers;

namespace FormsUI.Forms.LoginForms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        #region Window

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            var message = "Please, enter ";
            if (this.tbxUserName.Text != "Username")
            {
                if (this.tbxPassword.Text != "Password")
                {
                    if (this.tbxPasswordRepeat.Text != "Password Repeat")
                    {
                        if (this.tbxEmail.Text != "Email")
                        {
                            if (this.tbxFirstName.Text != "Firstname")
                            {
                                if (this.tbxLastName.Text != "Lastname")
                                {
                                    this.lblErrorMessage.Visible = false;
                                }
                                else
                                {
                                    SetErrorMessage(message + "lastname.");
                                }
                            }
                            else
                            {
                                SetErrorMessage(message + "firstname.");
                            }
                        }
                        else
                        {
                            SetErrorMessage(message + "email");
                        }
                    }
                    else
                    {
                        SetErrorMessage(message + "duplicate password.");
                    }
                }
                else
                {
                    SetErrorMessage(message + "password.");
                }
            }
            else
            {
                SetErrorMessage(message + "username.");
            }
        }

        private void SetErrorMessage(string message)
        {
            this.lblErrorMessage.Text = "       " + message;
            this.lblErrorMessage.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var loginForm = InstanceFactory.GetInstance<Login>(new FormModule());
            this.Close();
            loginForm.Show();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            this.btnBack.IconColor =Color.DarkGray;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            this.btnBack.IconColor = Color.Gainsboro;
        }
    }
}
