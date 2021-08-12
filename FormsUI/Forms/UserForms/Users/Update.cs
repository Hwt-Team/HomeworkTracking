using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.Users
{
    public partial class Update : Form
    {
        private IUserService _userService;

        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool Status { get; set; }

        public Update()
        {
            InitializeComponent();
            this._userService = InstanceFactory.GetInstance<IUserService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.tbxUserName.Text = this.UserName;
            this.tbxEmail.Text = this.Email;
            this.tbxFirstName.Text = this.FirstName;
            this.tbxLastName.Text = this.LastName;
            this.cbxStatus.CheckState = this.Status == true ? CheckState.Checked : CheckState.Unchecked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Changed user will be updated.",
                Ok = UpdateUser,
                Cancel = Cancel
            });
        }

        private void UpdateUser()
        {
            if (!string.IsNullOrEmpty(this.tbxPassword.Text))
            {
                var passDetails = this._userService.HashPassword(this.tbxPassword.Text);
                this.PasswordHash = passDetails.PasswordHash;
                this.PasswordSalt = passDetails.PasswordSalt;
            }

            this._userService.Update(new User
            {
                Id = this.Id,
                UserName = this.tbxUserName.Text,
                Email = this.tbxEmail.Text,
                FirstName = this.tbxFirstName.Text,
                LastName = this.tbxLastName.Text,
                Status = this.cbxStatus.Checked,
                PasswordHash = this.PasswordHash,
                PasswordSalt = this.PasswordSalt
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
