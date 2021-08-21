using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Utilities;

namespace FormsUI.Forms.StudentExerciseForms
{
    public partial class Search : Form
    {
        private readonly IStudentExercisesService _studentExercisesService;
        public StudentExerciseForm Form { get; set; }
        public Action LoadStudentExercises { get; set; }
        public DataGridView DgwStudentExercises { get; set; }
        public bool IsUser { get; set; }

        public Search()
        {
            InitializeComponent();
            this._studentExercisesService = InstanceFactory.GetInstance<IStudentExercisesService>(new BusinessModule());
            MainHelper.SetHelperFormName(this.panelStudentExerciseSearch, this.label);
        }

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        private void SetDataGridView(dynamic data, dynamic dtoData)
        {
            this.DgwStudentExercises.DataSource = this.IsUser
                ? dtoData
                : data;
        }

        private void tbxIdSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxIdSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                var id = int.Parse(text);
                //if (this.IsUser) this.DgwStudentExercises.DataSource = this._studentExercisesService.GetById(id);
                //else this.DgwStudentExercises.DataSource = this._studentExercisesService.GetStudentExercisesDtoById(id);
                this.SetDataGridView(
                    new List<StudentExercises> { this._studentExercisesService.GetById(id) },
                    this._studentExercisesService.GetStudentExercisesDtoById(id)
                    );
            }
            else
            {
                this.LoadStudentExercises.Invoke();
            }
        }

        private void tbxStudentIdSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxStudentIdSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                var studentId = int.Parse(text);
                this.SetDataGridView(
                    this._studentExercisesService.GetByStudentId(studentId, chbxActive.Checked),
                    this._studentExercisesService.GetStudentExercisesDtoByStudentId(studentId, chbxActive.Checked));
            }
            else
            {
                this.LoadStudentExercises.Invoke();
            }
        }

        private void tbxExerciseIdSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxExerciseIdSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                var exerciseId = int.Parse(text);
                this.SetDataGridView(
                    this._studentExercisesService.GetByExerciseId(exerciseId, chbxActive.Checked),
                    this._studentExercisesService.GetStudentExercisesDtoByExerciseId(exerciseId, chbxActive.Checked));
            }
            else
            {
                this.LoadStudentExercises.Invoke();
            }
        }

        private void chbxActive_CheckedChanged(object sender, EventArgs e)
        {
            this.SetDataGridView(
                this._studentExercisesService.GetActive(chbxActive.Checked),
                this._studentExercisesService.GetActiveDto(chbxActive.Checked)
                );
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
                    this.SetDataGridView(
                        this._studentExercisesService.GetStudentExercisesByFullName(text),
                        this._studentExercisesService.GetStudentExercisesDtoByFullName(text)
                        );
                }
                else if (firstName)
                {
                    this.SetDataGridView(
                        this._studentExercisesService.GetStudentExercisesByFirstName(text),
                        this._studentExercisesService.GetStudentExercisesDtoByFirstName(text)
                        );
                }
                else
                {
                    this.SetDataGridView(
                        this._studentExercisesService.GetStudentExercisesByLastName(text),
                        this._studentExercisesService.GetStudentExercisesDtoByLastName(text)
                        );
                }
            }
            else
            {
                LoadStudentExercises.Invoke();
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

        private void tbxExercise_TextChanged(object sender, EventArgs e)
        {
            var text = tbxExercise.Text;
            if (!String.IsNullOrEmpty(text))
            {
                this.SetDataGridView(
                    this._studentExercisesService.GetStudentExercisesByExerciseTitle(text),
                    this._studentExercisesService.GetStudentExercisesDtoByExerciseTitle(text)
                    );
            }
            else
            {
                LoadStudentExercises.Invoke();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelStudentExerciseSearch_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
