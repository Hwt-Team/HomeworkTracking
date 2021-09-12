using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.ObjectTypeForms
{
    public partial class Update : Form
    {
        private readonly IProjectObjectTypeService _projectObjectTypeService;
        public int Id { get; set; }
        public string ObjectTypeName { get; set; }
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion
        public Update()
        {
            InitializeComponent();
            this._projectObjectTypeService = InstanceFactory.GetInstance<IProjectObjectTypeService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelProjectObjectTypeUpdate, label);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Changed state will be updated.",
                Ok = UpdateState,
                Cancel = Cancel
            });
        }

        private void UpdateState()
        {
            this._projectObjectTypeService.Update(new ProjectObjectType
            {
                Id = this.Id,
                Name = tbxName.Text
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            tbxName.Text = this.ObjectTypeName;
        }

        private void panelStateUpdate_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
