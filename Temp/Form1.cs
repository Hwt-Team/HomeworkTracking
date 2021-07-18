using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsUI;
using FormsUI.Forms.GroupForms;

namespace Temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;

        }

        private void HideSubMenu()
        {
            if (panelMediaSubmenu.Visible)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubmenu.Visible)
                panelPlaylistSubmenu.Visible = false;
            if (panelToolsSubmenu.Visible)
                panelToolsSubmenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExerciseForm());
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnPlaylistManagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPlaylistSubmenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GroupForm());
            HideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelToolsSubmenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
