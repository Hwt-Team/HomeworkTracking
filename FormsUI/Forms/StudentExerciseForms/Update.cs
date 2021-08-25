using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.StudentExerciseForms
{
    public partial class Update : Form
    {
        private IStudentExercisesService _studentExercisesService;
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExerciseId { get; set; }
        public bool Active { get; set; }

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion


        public Update()
        {
            InitializeComponent();
            this._studentExercisesService = InstanceFactory.GetInstance<IStudentExercisesService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelStudentExerciseUpdate, label);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A student&exercise will be updated.",
                Ok = UpdateStudentExercise,
                Cancel = Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.tbxStudentId.Text = this.StudentId.ToString();
            this.tbxExerciseId.Text = this.ExerciseId.ToString();
            this.chbxActive.CheckState = this.Active == true
                ? CheckState.Checked
                : CheckState.Unchecked;
        }

        private void Cancel() { }

        private void UpdateStudentExercise()
        {
            _studentExercisesService.Update(new StudentExercises
            {
                Id = this.Id,
                StudentId = int.Parse(tbxStudentId.Text),
                ExerciseId = int.Parse(tbxStudentId.Text),
                Active = chbxActive.Checked
            });
        }

        private void panelStudentExerciseUpdate_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
