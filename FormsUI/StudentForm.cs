using System;
using System.Threading;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;

namespace FormsUI
{
    public partial class StudentForm : Form
    {
        private IStudentService _studentService;
        private Form1 _form1;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _studentService.Add(new Student
            {
                Id = this._studentService.GetLastRecord().Id + 1,
                FirstName = tbxFirstNameAdd.Text,
                LastName = tbxLastNameAdd.Text,
                GroupId = int.Parse(tbxGroupIdAdd.Text)
            });
            LoadStudents();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _studentService.Update(new Student
            {
                Id = (int) dgwStudents.CurrentRow.Cells[0].Value,
                FirstName = tbxFirstNameUpdate.Text,
                LastName = tbxLastNameUpdate.Text,
                GroupId = int.Parse(tbxGroupIdUpdate.Text)
            });
            LoadStudents();
            MessageBox.Show("Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _studentService.Delete(new Student
            {
                Id = (int) dgwStudents.CurrentRow.Cells[0].Value
            });
            LoadStudents();
            MessageBox.Show("Deleted!");
        }

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwStudents.CurrentRow.Cells;
            tbxFirstNameUpdate.Text = cells[1].Value.ToString();
            tbxLastNameUpdate.Text = cells[2].Value.ToString();
            tbxGroupIdUpdate.Text = cells[3].Value.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            _form1 = InstanceFactory.GetInstance<Form1>(new FormModule());
            _form1.Show(new Form1());
            this.Hide();
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
