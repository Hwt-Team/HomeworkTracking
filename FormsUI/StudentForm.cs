using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;

namespace FormsUI
{
    public partial class StudentForm : Form
    {
        private IStudentService _studentService;
        public StudentForm()
        {
            InitializeComponent();
            this._studentService = InstanceFactory
                .GetInstance<IStudentService>(new BusinessModule());
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgwStudents.DataSource = _studentService.GetAll();
        }
    }
}
