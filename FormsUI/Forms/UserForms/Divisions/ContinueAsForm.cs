using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Constants;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.Divisions
{
    public partial class ContinueAsForm : Form
    {
        private readonly IUserService _userService;
        private readonly IGraduateStudentService _graduateStudentService;
        private readonly IStudyingStudentService _studyingStudentService;
        private readonly IUserClaimService _userClaimService;
        private int _modeId = 0;
        private const int _dropShadow = 0x00080000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= _dropShadow;
                return cp;
            }
        }
        public User User { get; set; }

        public ContinueAsForm()
        {
            InitializeComponent();
            this._userService = InstanceFactory.GetInstance<IUserService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
            this._graduateStudentService = InstanceFactory.GetInstance<IGraduateStudentService>(new BusinessModule());
            this._studyingStudentService = InstanceFactory.GetInstance<IStudyingStudentService>(new BusinessModule());
            this._userClaimService = InstanceFactory.GetInstance<IUserClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void ContinueAsForm_Load(object sender, EventArgs e)
        {
            this.lblAdminInformation.Visible = false;
            this.tbxCode.Visible = false;
            this.dtpGraduateDate.Visible = false;
        }

        #region Dll import

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        private void panelContinueAs_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (this.cmbGender.Visible & this.cmbUserType.Visible)
            {
                if (this.cmbUserType.SelectedIndex != 0)
                    WarnMessageBox.MessageBox.ExecuteOptionAsDialog(new MessageBoxOptionParameter
                    {
                        Caption = CoreMessages.Caption,
                        Title = CoreMessages.ContinueAs,
                        Ok = this.ContinueAsUserType,
                        Cancel = this.Cancel
                    });
                this.ContinueAsGender();
                this.Close();
            }
        }

        private void ContinueAsUserType()
        {
            if (this.CheckUserTypeUpdateAvaiability())
            {
                this.ActivateMode();
                this.RunMode();
            }

        }

        private void ContinueAsGender()
        {
            if (this.CheckGenderUpdateAvailability()) this._userService.Update(this.FillUserPropertiesWithGenderId(this.GetGenderId()));

        }

        private void Cancel() { }

        private User FillUserPropertiesWithGenderId(int genderId)
        {
            return new User
            {
                Id = this.User.Id,
                UserName = this.User.UserName,
                Email = this.User.Email,
                FirstName = this.User.FirstName,
                LastName = this.User.LastName,
                PasswordHash = this.User.PasswordHash,
                PasswordSalt = this.User.PasswordSalt,
                Status = this.User.Status,
                GenderId = genderId
            };
        }

        private User FillUserProperties()
        {
            return new User
            {
                Id = this.User.Id,
                UserName = this.User.UserName,
                Email = this.User.Email,
                FirstName = this.User.FirstName,
                LastName = this.User.LastName,
                PasswordHash = this.User.PasswordHash,
                PasswordSalt = this.User.PasswordSalt,
                Status = this.User.Status
            };
        }

        private int GetGenderId()
        {
            if (this.cmbGender.SelectedItem.ToString() == "Male") return 1;
            else if (this.cmbGender.SelectedItem.ToString() == "Female") return 2;
            else return 0;
        }

        private bool CheckGenderUpdateAvailability()
        {
            return this.cmbGender.SelectedIndex != 0;
        }

        private bool CheckUserTypeUpdateAvaiability()
        {
            return this.cmbUserType.SelectedIndex != 0;
        }

        private void ActivateMode()
        {
            var userTypeId = this.cmbUserType.SelectedIndex;

            switch (userTypeId)
            {
                case 0:

                    break;
                case 1:
                    this.GraduateMode();
                    break;
                case 2:
                    this.StudyingMode();
                    break;
                case 3:
                    this.AdminMode();
                    break;
            }
        }

        private void RunMode()
        {
            switch (this._modeId)
            {
                case 0:

                    break;
                case 1:
                    this.RunGraduateMode();
                    break;
                case 2:
                    this.RunStudyingMode();
                    break;
                case 3:
                    this.RunAdminMode();
                    break;
            }
        }

        private void AdminMode()
        {
            this.lblGender.Text = "Code";
            this.cmbGender.Visible = false;
            this.cmbUserType.Visible = false;
            this.lblAdminInformation.Visible = true;
            this._modeId = 3;
            this.tbxCode.Visible = true;
        }

        private void RunAdminMode()
        {
            if (this.tbxCode.Text == "080821")
                this._userClaimService.Add(new UserClaim
                {
                    UserId = this.User.Id,
                    ClaimId = 1
                });
            else
                WarnMessageBox.MessageBox.ExecuteAsDialog(new MessageBoxParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = CoreMessages.ContactAdmin
                });

        }

        private void StudyingMode()
        {
            this._modeId = 2;
        }

        private void RunStudyingMode()
        {
            this._studyingStudentService.Add(this.FillUserProperties() as StudyingStudent);
        }

        private void GraduateMode()
        {
            this.lblGender.Text = "Graduate date";
            this._modeId = 1;
            this.cmbGender.Visible = false;
            this.cmbUserType.Visible = false;
            this.dtpGraduateDate.Visible = true;
            this.tbxCode.Visible = true;
        }

        private void RunGraduateMode()
        {
            if (this.tbxCode.Text == "071220")
            {
                var graduate = this.FillUserProperties() as GraduateStudent;
                graduate.GraduateDate = this.dtpGraduateDate.Value;
                this._graduateStudentService.Add(graduate);
            }
            else
                WarnMessageBox.MessageBox.ExecuteAsDialog(new MessageBoxParameter
                {
                    Caption = CoreMessages.Caption,
                    Title = CoreMessages.ContactAdmin
                });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
