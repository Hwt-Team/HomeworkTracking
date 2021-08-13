using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentExerciseForms
{
    public partial class Add : Form
    {
        private IStudentExercisesService _studentExercisesService;
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        public Add()
        {
            InitializeComponent();
            this._studentExercisesService = InstanceFactory.GetInstance<IStudentExercisesService>(new BusinessModule());
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new student&exercise will be added.",
                Ok = AddStudentExercise, 
                Cancel = Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel() { }

        private void AddStudentExercise()
        {
            _studentExercisesService.Add(new StudentExercises
            {
                Id = this._studentExercisesService.GetNextId(),
                StudentId = int.Parse(tbxStudentId.Text),
                ExerciseId = int.Parse(tbxExerciseId.Text),
                Active = true
            });
        }

        private void panelStudentExerciseAdd_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
