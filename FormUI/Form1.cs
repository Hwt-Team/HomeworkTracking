using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace FormUI
{
    public partial class Form1 : Form
    {
        private IStudentExercisesService _studentExercisesService;
        public Form1()
        {
            InitializeComponent();
            _studentExercisesService = InstanceFactory
                .GetInstance<IStudentExercisesService>(new BusinessModule());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
        }
        private void LoadStudentExercisesForUser()
        {
            dgwStudentExercisesUser.DataSource = _studentExercisesService.GetStudentExercisesDto();
        }

        private void LoadStudentExercisesForAdmin()
        {
            dgwStudentExercisesAdmin.DataSource = _studentExercisesService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _studentExercisesService.Add(new StudentExercises
            {
                StudentId = int.Parse(tbxStudentIdAdd.Text),
                ExerciseId = int.Parse(tbxExerciseIdAdd.Text),
                Active = true
            });
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _studentExercisesService.Update(new StudentExercises
            {
                Id = (int)dgwStudentExercisesAdmin.CurrentRow.Cells[0].Value,
                StudentId = int.Parse(tbxStudentIdUpdate.Text),
                ExerciseId = int.Parse(tbxStudentIdUpdate.Text),
                Active = chbxActiveUpdate.Checked
            });
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
            MessageBox.Show("Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _studentExercisesService.Delete(new StudentExercises
            {
                Id = (int)dgwStudentExercisesAdmin.CurrentRow.Cells[0].Value
            });
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
            MessageBox.Show("Deleted!");
        }

        private void dgwStudentExercisesAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwStudentExercisesAdmin.CurrentRow.Cells;
            tbxStudentIdUpdate.Text = cells[1].Value.ToString();
            tbxExerciseIdUpdate.Text = cells[2].Value.ToString();
            chbxActiveUpdate.CheckState = (bool)cells[3].Value ? CheckState.Checked : CheckState.Unchecked;
        }

        private void tbxIdSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxIdSearch.Text;
            var id = int.Parse(text);
            if (!String.IsNullOrEmpty(text))
            {
                dgwStudentExercisesAdmin.DataSource = _studentExercisesService.GetById(id);
                dgwStudentExercisesUser.DataSource = _studentExercisesService.GetStudentExercisesDtoById(id);
            }
            else
            {
                LoadStudentExercisesForAdmin();
                LoadStudentExercisesForUser();
            }
        }

        private void tbxStudentIdSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxStudentIdSearch.Text;
            var studentId = int.Parse(text);
            if (!String.IsNullOrEmpty(text))
            {
                dgwStudentExercisesAdmin.DataSource =
                    _studentExercisesService.GetByStudentId(studentId);
                dgwStudentExercisesUser.DataSource =
                    _studentExercisesService.GetStudentExercisesDtoByStudentId(studentId);
            }
            else
            {
                LoadStudentExercisesForAdmin();
                LoadStudentExercisesForUser();
            }
        }

        private void tbxExerciseIdSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxExerciseIdSearch.Text;
            var exerciseId = int.Parse(text);
            if (!String.IsNullOrEmpty(text))
            {
                dgwStudentExercisesAdmin.DataSource =
                    _studentExercisesService.GetByExerciseId(exerciseId);
                dgwStudentExercisesUser.DataSource =
                    _studentExercisesService.GetStudentExercisesDtoByExerciseId(exerciseId);
            }
            else
            {
                LoadStudentExercisesForAdmin();
                LoadStudentExercisesForUser();
            }
        }
    }
}
