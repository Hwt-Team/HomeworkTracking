using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.TaskForms
{
    public partial class Add : Form
    {
        private ITaskService _taskService;

        public Add()
        {
            InitializeComponent();
            this._taskService = InstanceFactory.GetInstance<ITaskService>(new BusinessModule());
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
                Deadline = dtpDeadline.Value == DateTime.Now
                    ? (DateTime?) null
                    : dtpDeadline.Value,
                StateId = int.Parse(tbxStateId.Text)
            });
        }
    }
}
