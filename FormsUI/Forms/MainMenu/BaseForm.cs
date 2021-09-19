using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Constants;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using FontAwesome.Sharp;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.ExerciseForms;
using FormsUI.Forms.GroupForms;
using FormsUI.Forms.MessageBox;
using FormsUI.Forms.StateForms;
using FormsUI.Forms.StudentExerciseForms;
using FormsUI.Forms.StudentForms.Both;
using FormsUI.Forms.StudentForms.Graduates;
using FormsUI.Forms.StudentForms.Studies;
using FormsUI.Forms.TaskForms;
using FormsUI.Forms.UserForms.Claims.Both;
using FormsUI.Forms.UserForms.Claims.Main;
using FormsUI.Forms.UserForms.Claims.Subsidiaries;
using FormsUI.Forms.UserForms.Divisions;
using FormsUI.Forms.UserForms.ObjectTypeForms;
using FormsUI.Forms.UserForms.ProjectObjectClaims;
using FormsUI.Forms.UserForms.ProjectObjects;
using FormsUI.Forms.UserForms.UserClaims;
using FormsUI.Forms.UserForms.Users;
using FormsUI.Utilities;

namespace FormsUI.Forms.MainMenu
{
    public partial class BaseForm : Form
    {
        private IconButton _currentButton;
        private readonly Panel _leftBorderButton;
        private Form _activeForm = null;
        private IconButton _locationalButton;

        public User User { get; set; }

        public BaseForm()
        {
            InitializeComponent();
            _leftBorderButton = new Panel { Size = new Size(7, 60) };
            panelSidebar.Controls.Add(_leftBorderButton);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            CustomizeDesign();
            this.SetHeightToUserManagement(200);


        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.lblUserName.Text = this.User?.UserName;
            this.lblName.Text = this.User?.FirstName + " " + this.User?.LastName;

            this.Authorize(this.User, this.panelSidebar.Controls);
        }

 

        #region Authorization

        private void Authorize(User user, System.Windows.Forms.Control.ControlCollection collection)
        {
            AuthorizationHelper.Authorize(user, collection);
        }

        #endregion

        #region Colors
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        #endregion

        #region Button Activation

        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton == null) return;
            if(!(this._currentButton is null)) this.DisableButton(this.GetColorOfButton((IconButton) _currentButton));
            _currentButton = (IconButton)senderButton;
            _currentButton.BackColor = Color.FromArgb(37, 36, 81);
            _currentButton.ForeColor = color;
            _currentButton.TextAlign = ContentAlignment.MiddleCenter;
            _currentButton.IconColor = color;
            _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            _currentButton.ImageAlign = ContentAlignment.MiddleRight;

            _leftBorderButton.BackColor = color;
            _leftBorderButton.Location = new Point(0, _currentButton.Location.Y);
            _leftBorderButton.Visible = true;
            _leftBorderButton.BringToFront();

            iconCurrentChildFormIcon.IconChar = _currentButton.IconChar;
            iconCurrentChildFormIcon.IconColor = color;
            _locationalButton = (IconButton)senderButton;
        }

        private Color GetColorOfButton(IconButton button)
        {
            var name = button.Parent.Name;
            if (name.Contains("SubMenu")) return Color.FromArgb(35, 32, 39);
            else if (name.Contains("Submenu")) return Color.FromArgb(46, 43, 51);
            else return Color.FromArgb(11, 7, 17);
        }

        private void ActivateSubMenuButton(object senderButton, Color color)
        {
            if (senderButton == null) return;
            //this.SetBackColor(out var tempColor);
            this.DisableButton(this.GetColorOfButton((IconButton) _currentButton));
            _currentButton = (IconButton)senderButton;
            _currentButton.BackColor = Color.FromArgb(37, 36, 81);
            _currentButton.ForeColor = color;
            _currentButton.TextAlign = ContentAlignment.MiddleCenter;
            _currentButton.IconColor = color;
            _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            _currentButton.ImageAlign = ContentAlignment.MiddleRight;

            iconCurrentChildFormIcon.IconChar = _currentButton.IconChar;
            iconCurrentChildFormIcon.IconColor = color;
        }

        private void SetBackColor(out Color color)
        {
            var panel = _currentButton.Parent.Name;
            if (panel.Substring(panel.Length - 7) == "SubMenu")
            {
                color = Color.FromArgb(35, 32, 39);
                return;
            }
            color = Color.FromArgb(11, 7, 17);

        }

        private void DisableButton(Color backColor)
        {
            if (_currentButton == null) return;
            _currentButton.BackColor = backColor;
            _currentButton.ForeColor = Color.Gainsboro;
            _currentButton.TextAlign = ContentAlignment.MiddleLeft;
            _currentButton.IconColor = Color.Gainsboro;
            _currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            _currentButton.ImageAlign = ContentAlignment.MiddleLeft;
        }

        #endregion

        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = this.FixChildFormName(childForm.Text);
        }

        private void SetHeightToUserManagement(int value)
        {
            this.panelUserManagement.Height = value;
        }

        private bool CheckClaimsSubMenuVisibility()
        {
            return this.panelClaimsSubmenu.Visible;
        }

        private string FixChildFormName(string childFormName)
        {
            return childFormName.Remove(childFormName.IndexOf("Form", StringComparison.Ordinal));
        }

        #region Sidebar menu click events
        private void btnExercises_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ExerciseForm());
        }

        private void btnStudentExercises_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new StudentExerciseForm());
        }

        #region Students
        private void btnStudents_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStudentSubMenu);
            ActivateButton(sender, RGBColors.color4);
        }
        private void btnBaseStudents_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color4);
            OpenChildForm(new StudentForm());
        }

        private void btnGraduates_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color4);
            OpenChildForm(new GraduateForm());
        }

        private void btnStudies_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color4);
            OpenChildForm(new StudiesForm());
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color2);
            OpenChildForm(new GroupForm());
        }

        #endregion

        #region ITask management
        private void btnITaskSubmenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelITaskSubMenu);
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnITask_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color5);
            OpenChildForm(new TaskForm());
        }

        private void btnStates_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color5);
            OpenChildForm(new StateForm());
        }

        #endregion

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            //OpenChildForm(new CalendarForm());
        }

        #region User management

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(this.panelUserManagement);
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color1);
            OpenChildForm(new UserForm());
        }

        private void btnUserClaims_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color2);
            OpenChildForm(new UserClaimForm());
        }

        private void btnProjectObjects_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color3);
            OpenChildForm(new ProjectObjectForm());
        }

        private void btnProjectObjectType_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color4);
            OpenChildForm(new ProjectObjectTypeForm());
        }

        #region Claims

        private void btnClaims_Click(object sender, EventArgs e)
        {
            ShowSubMenu(this.panelClaimsSubmenu);
            ActivateSubMenuButton(sender, RGBColors.color4);
            if (this.CheckClaimsSubMenuVisibility()) this.SetHeightToUserManagement(345);
            else this.SetHeightToUserManagement(200);
        }

        private void btnBaseClaims_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color5);
            OpenChildForm(new ClaimForm());
        }

        private void btnMainClaims_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color6);
            OpenChildForm(new MainClaimForm());
        }

        private void btnSubsidiaryClaims_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color1);
            OpenChildForm(new SubsidiaryClaimForm());
        }

        #endregion

        private void btnProjectObjectClaims_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color2);
            OpenChildForm(new ProjectObjectClaimForm());
        }

        #endregion

        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {
            _activeForm?.Hide();
            Reset();
        }

        private void Reset()
        {
            //this.SetBackColor(out var color);
            DisableButton(this.GetColorOfButton(this._currentButton));
            _leftBorderButton.Visible = false;
            this.panelITaskSubMenu.Visible = false;
            this.panelStudentSubMenu.Visible = false;
            this.panelUserManagement.Visible = false;
            this.panelClaimsSubmenu.Visible = false;
            iconCurrentChildFormIcon.IconChar = IconChar.Home;
            iconCurrentChildFormIcon.IconColor = Color.Gainsboro;
            lblTitleChildForm.Text = "Home";
        }

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion


        private void panelNavbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //private void panelNavbar_MouseMove(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        #region WindowState

        private void Cancel() { }

        private void Ok()
        {
            Application.Exit();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = CoreMessages.Caption,
                Title = Messages.Exit,
                Ok = Ok,
                Cancel = Cancel
            });

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                this.btnMaximize.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.btnMaximize.IconChar = IconChar.WindowMaximize;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region OpenForm Alternative
        //private void OpenForm<TForm>() where TForm : Form, new()
        //{
        //    Form form = panelContainer.Controls.OfType<TForm>().FirstOrDefault();
        //    if (form is null)
        //    {
        //        form = new TForm
        //        {
        //            TopLevel = false,
        //            FormBorderStyle = FormBorderStyle.None,
        //            Dock = DockStyle.Fill
        //        };
        //        panelContainer.Controls.Add(form);
        //        panelContainer.Tag = form;
        //        form.Show();
        //        form.BringToFront();
        //        form.FormClosed += new FormClosedEventHandler(CloseForms);
        //    }
        //    else
        //    {
        //        form.BringToFront();
        //    }

        //}
        #endregion

        #region Submenu integration
        private void CustomizeDesign()
        {
            SetVisibilityToPanelStudentsSubMenu(false);
            SetVisibilityToPanelITaskSubMenu(false);
            SetVisibilityToPanelUserManagement(false);
            SetVisibilityToPanelClaims(false);
        }

        private void SetVisibilityToPanelStudentsSubMenu(bool value)
        {
            panelStudentSubMenu.Visible = value;
        }

        private void SetVisibilityToPanelITaskSubMenu(bool value)
        {
            panelITaskSubMenu.Visible = value;
        }

        private void SetVisibilityToPanelUserManagement(bool value)
        {
            panelUserManagement.Visible = value;
        }

        private void SetVisibilityToPanelClaims(bool value)
        {
            panelClaimsSubmenu.Visible = value;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //SetVisibilityToPanelStudentsSubMenu(false);
                //SetVisibilityToPanelITaskSubMenu(false);
                //SetVisibilityToPanelUserManagement(false);
                //SetVisibilityToPanelClaims(false);
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        #endregion

        #region Multi Window Work Around Configuration
        //private void CloseForms(object sender, FormClosedEventArgs e)
        //{
        //    if (Application.OpenForms["ExerciseForm"] is null)
        //        ActivateButton(btnExercises, RGBColors.color1);
        //    if (Application.OpenForms["GroupForm"] is null)
        //        ActivateButton(btnGroups, RGBColors.color2);
        //    if (Application.OpenForms["Form1"] is null)
        //        ActivateButton(btnStudentExercises, RGBColors.color3);
        //    if (Application.OpenForms["StudentForm"] is null)
        //        ActivateButton(btnBaseStudents, RGBColors.color3);
        //if (Application.OpenForms["GraduateForm"] is null)
        //    ActivateButton(btnGraduates, RGBColors.color3);
        //if (Application.OpenForms["StudiesForm"] is null)
        //    ActivateButton(btnBaseStudents, RGBColors.color3);
        //if (Application.OpenForms["TaskForm"] is null)
        //    ActivateButton(btnITask, RGBColors.color3);
        //if (Application.OpenForms["StudentForm"] is null)
        //    ActivateButton(btnBaseStudents, RGBColors.color3);
        //}
        #endregion

        #region Resize Rectangle

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelBase.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }





        #endregion

        private void btnUserDetail_Click(object sender, EventArgs e)
        {
            var form = InstanceFactory.GetInstance<ContinueAsForm>(new FormModule());
            form.User = this.User;
            form.ShowDialog();

        }

    }
}
