using Business.Abstract;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.Forms.MessageBox;
using System;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.Users
{
    public partial class Add : Form
    {
        private readonly IUserService _userService;
        public Add()
        {
            InitializeComponent();
            this._userService = InstanceFactory
                .GetInstance<IUserService>(new CoreModule());
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new user will be added.",
                Ok = this.AddUser,
                Cancel = this.Cancel
            });
        }

        private void AddUser()
        {
            this._userService.Add(new User
            {
                Id = this._userService.GetNextId(),
                UserName = this.tbxUserName.Text,
                Email = this.tbxEmail.Text,
                FirstName = this.tbxFirstName.Text,
                LastName = this.tbxLastName.Text,
                Status = this.cbxStatus.Checked,
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
