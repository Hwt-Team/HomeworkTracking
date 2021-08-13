using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentForms.Graduates
{
    public partial class Update : Form
    {
        private readonly IGraduateStudentService _graduateStudentService;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public DateTime GraduateDate { get; set; }
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        public Update()
        {
            InitializeComponent();
            this._graduateStudentService = InstanceFactory
                .GetInstance<IGraduateStudentService>(new BusinessModule());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Changed graduate will be updated.",
                Ok = UpdateGraduate,
                Cancel = Cancel
            });
        }

        private void UpdateGraduate()
        {
            this._graduateStudentService.Update(new GraduateStudent
            {
                Id = this.Id,
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                GroupId = int.Parse(tbxGroupId.Text),
                GraduateDate = dtpGraduateDate.Value
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            SetDatetimePickerFormat();
            tbxFirstName.Text = this.FirstName;
            tbxLastName.Text = this.LastName;
            tbxGroupId.Text = this.GroupId.ToString();
            dtpGraduateDate.Value = this.GraduateDate;
        }

        private void SetDatetimePickerFormat()
        {
            dtpGraduateDate.Format = DateTimePickerFormat.Custom;
            dtpGraduateDate.ShowUpDown = true;
            dtpGraduateDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
        }

        private void panelGraduateUpdate_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
