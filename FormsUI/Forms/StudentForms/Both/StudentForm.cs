using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;

namespace FormsUI.Forms.StudentForms.Both
{
    public partial class StudentForm : Form
    {
        private readonly IStudentService _studentService;
        private readonly IStudyingStudentService _studyingStudentService;
        private readonly IGraduateStudentService _graduateStudentService;

        public StudentForm()
        {
            InitializeComponent();
            this._studentService = InstanceFactory
                .GetInstance<IStudentService>(new BusinessModule());
            this._studyingStudentService = InstanceFactory
                .GetInstance<IStudyingStudentService>(new BusinessModule());
            this._graduateStudentService = InstanceFactory
                .GetInstance<IGraduateStudentService>(new BusinessModule());

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.LoadAllStudents();
            this.DesignDataGridView(dgwStudents);
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

        private void LoadAllStudents()
        {
            this.dgwStudents.DataSource = this._studentService.GetAll();
        }

        private void LoadStudies()
        {
            this.dgwStudents.DataSource = this._studyingStudentService.GetAll();
        }

        private void LoadGraduates()
        {
            this.dgwStudents.DataSource = this._graduateStudentService.GetAll();
        }

        private void btnStudiesDgw_Click(object sender, EventArgs e)
        {
            this.LoadStudies();
        }

        private void btnGraduatesDgw_Click(object sender, EventArgs e)
        {
            this.LoadGraduates();
        }

        private void btnBothDgw_Click(object sender, EventArgs e)
        {
            this.LoadAllStudents();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadAllStudents();
        }
    }
}
