using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;

namespace FormsUI.Forms.StudentExerciseForms
{
    public partial class StudentExerciseForm : Form
    {
        private readonly IStudentExercisesService _studentExercisesService;
        private IStudentService _studentService;
        private IExerciseService _exerciseService;
        

        public StudentExerciseForm()
        {
            this._studentService = InstanceFactory
                .GetInstance<IStudentService>(new BusinessModule());
            InitializeComponent();
            this._studentExercisesService = InstanceFactory
                .GetInstance<IStudentExercisesService>(new BusinessModule());
            this._exerciseService = InstanceFactory
                .GetInstance<IExerciseService>(new BusinessModule());
        }

        private void StudentExerciseForm_Load(object sender, EventArgs e)
        {
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
        }

        private void LoadStudentExercisesForUser()
        {
            dgwStudentExercisesUser.DataSource = this._studentExercisesService.GetStudentExercisesDto();
        }

        private void LoadStudentExercisesForAdmin()
        {
            dgwStudentExercisesAdmin.DataSource = this._studentExercisesService.GetAll();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = InstanceFactory.GetInstance<Add>(new FormModule());
            addForm.Show();
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = InstanceFactory.GetInstance<Update>(new FormModule());
            updateForm.Id = (int) this.dgwStudentExercisesAdmin.CurrentRow.Cells[0].Value;
            updateForm.StudentId = (int) this.dgwStudentExercisesAdmin.CurrentRow.Cells[1].Value;
            updateForm.ExerciseId = (int) this.dgwStudentExercisesAdmin.CurrentRow.Cells[0].Value;
            updateForm.Active = this.chbxActive.Checked;
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _studentExercisesService.Delete(new StudentExercises
            {
                Id = (int)dgwStudentExercisesAdmin.CurrentRow.Cells[0].Value
            });
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
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

        private void chbxFirstName_CheckedChanged(object sender, EventArgs e)
        {
            this.tbxStudentName_TextChanged(sender, e);
        }

        private void chbxLastName_CheckedChanged(object sender, EventArgs e)
        {
            this.tbxStudentName_TextChanged(sender, e);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            this._studentExercisesService.DeleteAll();
            LoadStudentExercisesForAdmin();
            LoadStudentExercisesForUser();
        }
    }
}
