using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;

namespace FormsUI
{
    public partial class ExerciseForm : Form
    {
        private IExerciseService _exerciseService;
        private Form1 _form1;
        public ExerciseForm()
        {
            InitializeComponent();
            this._exerciseService = InstanceFactory
                .GetInstance<IExerciseService>(new BusinessModule());
        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            LoadExercises();
            SetDatetimePickerFormat();
            SetDatetimeValue();
        }

        private void SetDatetimeValue()
        {
            dtpDeadlineAdd.MinDate = DateTime.Now;
            dtpDeadlineUpdate.MinDate = DateTime.Now;
        }

        private void SetDatetimePickerFormat()
        {
            dtpDeadlineAdd.Format = DateTimePickerFormat.Custom;
            dtpDeadlineAdd.ShowUpDown = true;
            dtpDeadlineAdd.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtpDeadlineUpdate.Format = DateTimePickerFormat.Custom;
            dtpDeadlineUpdate.ShowUpDown = true;
            dtpDeadlineUpdate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void LoadExercises()
        {
            dgwExercises.DataSource = this._exerciseService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._exerciseService.Add(new Exercise
            {
                Title = tbxTitleAdd.Text,
                Deadline = dtpDeadlineAdd.CustomFormat == " " 
                    ? (DateTime?)null 
                    : dtpDeadlineAdd.Value
            });
            LoadExercises();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._exerciseService.Update(new Exercise
            {
                Id = (int) dgwExercises.CurrentRow.Cells[0].Value,
                Title = tbxTitleUpdate.Text,
                Deadline = dtpDeadlineUpdate.CustomFormat == " "
                    ? (DateTime?)null
                    : dtpDeadlineUpdate.Value
            });
            LoadExercises();
            MessageBox.Show("Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._exerciseService.Delete(new Exercise
            {
                Id = (int) dgwExercises.CurrentRow.Cells[0].Value
            });
            LoadExercises();
            MessageBox.Show("Deleted!");
        }

        private void dgwExercises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwExercises.CurrentRow?.Cells;
            tbxTitleUpdate.Text = cells[1].Value.ToString();
            object value = cells[2]?.Value;
            if (value != null) dtpDeadlineUpdate.Value = (DateTime) value;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            _form1 = InstanceFactory.GetInstance<Form1>(new FormModule());
            _form1.Show();
            this.Hide();
        }

        private void ExerciseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dtpDeadlineUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back | e.KeyCode == Keys.Delete)
            {
                dtpDeadlineUpdate.CustomFormat = " ";
            }
        }

        private void dtpDeadlineAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back | e.KeyCode == Keys.Delete)
            {
                dtpDeadlineAdd.CustomFormat = " ";
            }
        }
    }
}
