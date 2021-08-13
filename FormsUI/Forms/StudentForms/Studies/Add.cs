using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentForms.Studies
{
    public partial class Add : Form
    {
        private readonly IStudyingStudentService _studyingStudentService;
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        public Add()
        {
            InitializeComponent();
            this._studyingStudentService = InstanceFactory
                .GetInstance<IStudyingStudentService>(new BusinessModule());
        }

        private void Add_Load(object sender, EventArgs e)
        {
            //...
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new studying will be added.",
                Ok = AddStudying,
                Cancel = Cancel
            });
        }

        private void AddStudying()
        {
            this._studyingStudentService.Add(new StudyingStudent
            {
                Id = this._studyingStudentService.GetNextId(),
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                GroupId = int.Parse(tbxGroupId.Text),
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelStudiesAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
