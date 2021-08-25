using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.StudentForms.Graduates
{
    public partial class Add : Form
    {
        private readonly IGraduateStudentService _graduateStudentService;
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        public Add()
        {
            InitializeComponent();
            this._graduateStudentService = InstanceFactory
                .GetInstance<IGraduateStudentService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelGraduateAdd, label);
        }

        private void Add_Load(object sender, EventArgs e)
        {
            SetDatetimeValue();
            SetDatetimePickerFormat();
        }

        private void SetDatetimeValue()
        {
            dtpGraduateDate.MinDate = DateTime.Now;
        }

        private void SetDatetimePickerFormat()
        {
            dtpGraduateDate.Format = DateTimePickerFormat.Custom;
            dtpGraduateDate.ShowUpDown = true;
            dtpGraduateDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new state will be added.",
                Ok = AddGraduate,
                Cancel = Cancel
            });
        }

        private void AddGraduate()
        {
            this._graduateStudentService.Add(new GraduateStudent
            {
                Id = this._graduateStudentService.GetNextId(),
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
       
        private void panelGraduateAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
