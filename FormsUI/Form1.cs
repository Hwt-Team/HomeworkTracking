using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;

namespace FormsUI
{
    public partial class Form1 : Form
    {
        private IStudentExercisesService _studentExercisesService;
        private IStudentService _studentService;
        private IExerciseService _exerciseService;
        public Form1()
        {
            this._studentService = InstanceFactory
                .GetInstance<IStudentService>(new BusinessModule());
            InitializeComponent();
            this._studentExercisesService = InstanceFactory
                .GetInstance<IStudentExercisesService>(new BusinessModule());
            this._exerciseService = InstanceFactory
                .GetInstance<IExerciseService>(new BusinessModule());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
            LoadStudents();
            LoadExercises();
        }

        private void LoadStudentExercisesForUser()
        {
            dgwStudentExercisesUser.DataSource = this._studentExercisesService.GetStudentExercisesDto();
        }

        private void LoadStudentExercisesForAdmin()
        {
            dgwStudentExercisesAdmin.DataSource = this._studentExercisesService.GetAll();
        }

        private void LoadStudents()
        {
            dgwStudents.DataSource = this._studentService.GetAll();
        }

        private void LoadExercises()
        {
            dgwExercises.DataSource = this._exerciseService.GetAll();
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
            var cells = dgwStudentExercisesAdmin.CurrentRow?.Cells;
            tbxStudentIdUpdate.Text = cells[1].Value.ToString();
            tbxExerciseIdUpdate.Text = cells[2].Value.ToString();
            chbxActiveUpdate.CheckState = (bool)cells[3].Value ? CheckState.Checked : CheckState.Unchecked;
        }

        private void tbxIdSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxIdSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                var id = int.Parse(text);
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
            if (!String.IsNullOrEmpty(text))
            {
                var studentId = int.Parse(text);
                dgwStudentExercisesAdmin.DataSource =
                    _studentExercisesService.GetByStudentId(studentId, chbxActive.Checked);
                dgwStudentExercisesUser.DataSource =
                    _studentExercisesService.GetStudentExercisesDtoByStudentId(studentId, chbxActive.Checked);
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
            if (!String.IsNullOrEmpty(text))
            {
                var exerciseId = int.Parse(text);
                dgwStudentExercisesAdmin.DataSource =
                    _studentExercisesService.GetByExerciseId(exerciseId, chbxActive.Checked);
                dgwStudentExercisesUser.DataSource =
                    _studentExercisesService.GetStudentExercisesDtoByExerciseId(exerciseId, chbxActive.Checked);
            }
            else
            {
                LoadStudentExercisesForAdmin();
                LoadStudentExercisesForUser();
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            var student = InstanceFactory.GetInstance<StudentForm>(new FormModule());
            student.Show();
            this.Hide();
        }

        private void btnExercises_Click(object sender, EventArgs e)
        {
            var exercise = InstanceFactory.GetInstance<ExerciseForm>(new FormModule());
            exercise.Show();
            this.Hide();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            var group = InstanceFactory.GetInstance<GroupForm>(new FormModule());
            group.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgwExercises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgwExercises.CurrentRow?.Cells[1].Value.ToString(), "Title :");
        }

        private void chbxActive_CheckedChanged(object sender, EventArgs e)
        {
            dgwStudentExercisesAdmin.DataSource = this._studentExercisesService.GetActive(chbxActive.Checked);
            dgwStudentExercisesUser.DataSource = this._studentExercisesService.GetActiveDto(chbxActive.Checked);
        }

        private void tbxStudentName_TextChanged(object sender, EventArgs e)
        {
            var text = tbxStudentName.Text;
            var firstName = chbxFirstName.Checked;
            var lastName = chbxLastName.Checked;

            if (!String.IsNullOrEmpty(text))
            {
                if (firstName & lastName)
                {
                    dgwStudentExercisesAdmin.DataSource = _studentExercisesService.GetStudentExercisesByFullName(text);
                    dgwStudentExercisesUser.DataSource = _studentExercisesService.GetStudentExercisesDtoByFullName(text);
                }
                else if (firstName)
                {
                    dgwStudentExercisesAdmin.DataSource = _studentExercisesService.GetStudentExercisesByFirstName(text);
                    dgwStudentExercisesUser.DataSource = _studentExercisesService.GetStudentExercisesDtoByFirstName(text);
                }
                else
                {
                    dgwStudentExercisesAdmin.DataSource = _studentExercisesService.GetStudentExercisesByLastName(text);
                    dgwStudentExercisesUser.DataSource = _studentExercisesService.GetStudentExercisesDtoByLastName(text);
                }
            }
            else
            {
                LoadStudentExercisesForAdmin();
                LoadStudentExercisesForUser();
            }


        }

        private void tbxExercise_TextChanged(object sender, EventArgs e)
        {
            var text = tbxExercise.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwStudentExercisesAdmin.DataSource =
                    this._studentExercisesService.GetStudentExercisesByExerciseTitle(text);
                dgwStudentExercisesUser.DataSource =
                    this._studentExercisesService.GetStudentExercisesDtoByExerciseTitle(text);
            }
            else
            {
                LoadStudentExercisesForAdmin();
                LoadStudentExercisesForUser();
            }
        }
    }
}
