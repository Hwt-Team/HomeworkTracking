using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsUI.Forms.ExerciseForms;

namespace FormsUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            CustomizeDesign();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

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
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelBase.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        #endregion

        private void CustomizeDesign()
        {
            SetVisibilityToPanelStudentsSubMenu(false);
        }


        private void SetVisibilityToPanelStudentsSubMenu(bool value)
        {
            panelStudentsSubMenu.Visible = value;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                SetVisibilityToPanelStudentsSubMenu(false);
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStudentsSubMenu);
        }

        private void btnBaseStudents_Click(object sender, EventArgs e)
        {
            SetVisibilityToPanelStudentsSubMenu(false);
        }

        private void btnGraduateStudents_Click(object sender, EventArgs e)
        {
            SetVisibilityToPanelStudentsSubMenu(false);
        }

        private void btnStudyingStudents_Click(object sender, EventArgs e)
        {
            SetVisibilityToPanelStudentsSubMenu(false);
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnExercises_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExerciseForm());
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm());
        }
    }
}
