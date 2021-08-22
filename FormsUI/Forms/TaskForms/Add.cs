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
    public partial class Add : Form
    {
        private ITaskService _taskService;
        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        public Add()
        {
            InitializeComponent();
            this._taskService = InstanceFactory.GetInstance<ITaskService>(new BusinessModule());
            MainHelper.SetHelperFormName(panelTaskAdd, label);
        }

        private void Add_Load(object sender, EventArgs e)
        {
            SetDatetimeValue();
            SetDatetimePickerFormat();          
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new exercise will be added.",
                Ok = AddTask,
                Cancel = Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel() { }

        private void AddTask()
        {
            this._taskService.Add(new Task
            {
                Id = this._taskService.GetNextId(),
                Title = tbxTitle.Text,
                Detail = tbxDetail.Text,
                Deadline = cbxTaskAdd.Checked
                ? dtpDeadline.Value
                : (DateTime?)null,
                StateId = int.Parse(tbxStateId.Text)
            });
        }

        private void panelTaskAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbxTaskAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTaskAdd.Checked)
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
