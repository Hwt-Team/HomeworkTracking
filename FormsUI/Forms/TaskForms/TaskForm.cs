using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.TaskForms
{
    public partial class TaskForm : Form
    {
        private ITaskService _taskService;
        public TaskForm()
        {
            InitializeComponent();
            this._taskService = InstanceFactory.GetInstance<ITaskService>(new BusinessModule());
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            LoadTasks();
            DesignDataGridView(dgwTasks);
        }

        private void DesignDataGridView(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 30, 45);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 21, 32);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadTasks()
        {
            dgwTasks.DataSource = this._taskService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadTasks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            var cells = this.dgwTasks.CurrentRow?.Cells;
            updateForm.Id = (int) cells[0].Value;
            updateForm.Title = cells[1].Value.ToString();
            updateForm.Detail = cells[2].Value.ToString();
            updateForm.Deadline = (DateTime) cells[3].Value;
            updateForm.StateId = (int) cells[4].Value;
            updateForm.Show();
            LoadTasks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Selected task will be deleted.",
                Ok = DeleteTask,
                Cancel = Cancel
            });
        }

        private void DeleteTask()
        {
            this._taskService.Delete(new Task
            {
                Id = (int) dgwTasks.CurrentRow?.Cells[0].Value
            });
            LoadTasks();
        }

        private void Cancel() { }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "All data will be deleted.",
                Ok = DeleteAll,
                Cancel = Cancel
            });
            LoadTasks();
        }

        private void DeleteAll()
        {
            this._taskService.DeleteAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void dgwTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
            {
                Caption = "System",
                Title = this.dgwTasks.CurrentRow?.Cells[1].Value 
                        + "\n\n" 
                        + this.dgwTasks.CurrentRow?.Cells[2].Value
            });
        }
    }
}
