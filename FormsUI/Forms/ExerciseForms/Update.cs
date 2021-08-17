using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.ExerciseForms
{
    public partial class Update : Form
    {
        private IExerciseService _exerciseService;
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Deadline { get; set; }

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion


        public Update()
        {
            InitializeComponent();
            this._exerciseService = InstanceFactory.GetInstance<IExerciseService>(new BusinessModule());
        }

        private void SetDatetimeValue()
        {
            dtpDeadline.MinDate = DateTime.Now;
        }

        private void SetDatetimePickerFormat()
        {
            dtpDeadline.Format = DateTimePickerFormat.Custom;
            dtpDeadline.ShowUpDown = true;
            dtpDeadline.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Changed exercise will be updated.",
                Ok = UpdateExercise,
                Cancel = Cancel
            });
        }

        private void UpdateExercise()
        {
            this._exerciseService.Update(new Exercise
            {
                Id = this.Id,
                Title = tbxTitle.Text,
                Deadline = cbxExerciseUpdate.Checked 
                ? dtpDeadline.Value
                : (DateTime?)null

            });
        }

        private void Cancel() { }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            tbxTitle.Text = this.Title;
            dtpDeadline.Value = this.Deadline ?? DateTime.Now;
            SetDatetimePickerFormat();
        }

        private void panelExerciseUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbxExerciseAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxExerciseUpdate.Checked)
            {
                lblDeadline.ForeColor = System.Drawing.Color.Gainsboro;
                dtpDeadline.Enabled = true;
            }
            else
            {
                lblDeadline.ForeColor = System.Drawing.Color.Gray;
                dtpDeadline.Enabled = false;

            }
        }
    }
}
