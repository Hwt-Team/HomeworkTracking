﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using FormsUI.Forms.ExerciseForms;
using FormsUI.Forms.GroupForms;
using FormsUI.Forms.StateForms;
using FormsUI.Forms.StudentExerciseForms;
using FormsUI.Forms.StudentForms.Both;
using FormsUI.Forms.StudentForms.Graduates;
using FormsUI.Forms.StudentForms.Studies;
using FormsUI.Forms.TaskForms;

namespace FormsUI.Forms.MainMenu
{
    public partial class BaseForm : Form
    {
        private IconButton _currentButton;
        private readonly Panel _leftBorderButton;
        private Form _activeForm = null;
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
        }

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
            this.DisableButton(Color.FromArgb(11,7,17));
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

        private void ActivateSubMenuButton(object senderButton, Color color)
        {
            if (senderButton == null) return;
            this.SetBackColor(out var tempColor);
            this.DisableButton(tempColor);
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
        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {
            _activeForm?.Hide();
            Reset();
        }

        private void Reset()
        {
            this.SetBackColor(out var color);
            DisableButton(color);
            _leftBorderButton.Visible = false;
            this.panelITaskSubMenu.Visible = false;
            this.panelStudentSubMenu.Visible = false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
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
        }

        private void SetVisibilityToPanelStudentsSubMenu(bool value)
        {
            panelStudentSubMenu.Visible = value;
        }

        private void SetVisibilityToPanelITaskSubMenu(bool value)
        {
            panelITaskSubMenu.Visible = value;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                SetVisibilityToPanelStudentsSubMenu(false);
                SetVisibilityToPanelITaskSubMenu(false);
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

    }
}