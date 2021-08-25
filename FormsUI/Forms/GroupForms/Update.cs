using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.GroupForms
{
    public partial class Update : Form
    {
        private IGroupService _groupService;
        public int Id { get; set; }
        public string GroupName { get; set; }
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion
        public Update()
        {
            InitializeComponent();
            this._groupService = InstanceFactory.GetInstance<IGroupService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelExerciseUpdate, label);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A group will be updated.",
                Ok = UpdateGroup,
                Cancel = Cancel
            });
        }

        private void UpdateGroup()
        {
            this._groupService.Update(new Group
            {
                Id = this.Id,
                Name = tbxName.Text
            });
        }

        private void Cancel()
        {
            //...
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            tbxName.Text = this.GroupName;
        }

        private void panelExerciseUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
