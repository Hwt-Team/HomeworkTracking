using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;
using FormsUI.Utilities;

namespace FormsUI.Forms.TaskForms
{
    public partial class Update : Form
    {
        private ITaskService _taskService;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime? Deadline { get; set; }
        public int StateId { get; set; }
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        public Update()
        {
            InitializeComponent();
            this._taskService = InstanceFactory.GetInstance<ITaskService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelTaskUpdate, label);
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


        private void UpdateTask()
        {
            this._taskService.Update(new Task
            {
                Id = this.Id,
                Title = tbxTitle.Text,
                Detail = tbxDetail.Text,
                Deadline = cbxTaskUpdate.Checked
                ? dtpDeadline.Value
                : (DateTime?)null,
                StateId = int.Parse(tbxStateId.Text)
            }) ;
        }

        private void Cancel() { }

        private void Update_Load(object sender, EventArgs e)
        {
            tbxTitle.Text = this.Title;
            tbxDetail.Text = this.Detail;
            dtpDeadline.Value = this.Deadline ?? DateTime.Now;
            tbxStateId.Text = this.StateId.ToString();
            SetDatetimeValue();
            SetDatetimePickerFormat();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Changed task will be updated.",
                Ok = UpdateTask,
                Cancel = Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTaskUpdate_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbxTaskUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTaskUpdate.Checked)
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
