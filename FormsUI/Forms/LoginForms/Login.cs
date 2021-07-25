using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Core.DependencyResolvers.Ninject;
using FormsUI.DependencyResolvers;

namespace FormsUI.Forms.LoginForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            if (this.tbxUserName.Text != "Username or Email")
            {
                if (this.tbxPassword.Text != "Password")
                {
                    this.lblErrorMessage.Visible = false;

                }
                else
                {
                    SetErrorMessage("Please, enter password.");
                }
            }
            else
            {
                SetErrorMessage("Please, enter username.");
            }
        }

        private void SetErrorMessage(string message)
        {
            this.lblErrorMessage.Text = "       " + message;
            this.lblErrorMessage.Visible = true;
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
    }
}
