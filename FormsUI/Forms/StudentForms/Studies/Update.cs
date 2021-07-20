using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentForms.Studies
{
    public partial class Update : Form
    {
        private readonly IStudyingStudentService _studyingStudentService;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }

        public Update()
        {
            InitializeComponent();
            this._studyingStudentService = InstanceFactory
                .GetInstance<IStudyingStudentService>(new BusinessModule());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Changed studying will be updated.",
                Ok = UpdateStudying,
                Cancel = Cancel
            });
        }

        private void UpdateStudying()
        {
            this._studyingStudentService.Update(new StudyingStudent
            {
                Id = this.Id,
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                GroupId = int.Parse(tbxGroupId.Text)
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            tbxFirstName.Text = this.FirstName;
            tbxLastName.Text = this.LastName;
            tbxGroupId.Text = this.GroupId.ToString();
        }
    }
}
