using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StudentForms.Studies
{
    public partial class Add : Form
    {
        private readonly IStudyingStudentService _studyingStudentService;
        public Add()
        {
            InitializeComponent();
            this._studyingStudentService = InstanceFactory
                .GetInstance<IStudyingStudentService>(new BusinessModule());
        }

        private void Add_Load(object sender, EventArgs e)
        {
            //...
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new studying will be added.",
                Ok = AddStudying,
                Cancel = Cancel
            });
        }

        private void AddStudying()
        {
            this._studyingStudentService.Add(new StudyingStudent
            {
                Id = this._studyingStudentService.GetNextId(),
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                GroupId = int.Parse(tbxGroupId.Text),
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
