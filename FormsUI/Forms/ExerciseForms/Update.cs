using System;
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
                Deadline = dtpDeadline.Value == DateTime.Now 
                    ? (DateTime?) null
                    : dtpDeadline.Value

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
    }
}
