using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.GroupForms
{
    public partial class Update : Form
    {
        private IGroupService _groupService;
        public int Id { get; set; }
        public string GroupName { get; set; }
        public Update()
        {
            InitializeComponent();
            this._groupService = InstanceFactory.GetInstance<IGroupService>(new BusinessModule());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A group will be updated.",
                Ok = UpdateGroup,
                Cancel = Cancel
            });
        }

        private void UpdateGroup()
        {
            this._groupService.Update(new Group
            {
                Id = this.Id,
                Name = tbxName.Text
            });
        }

        private void Cancel()
        {
            //...
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            tbxName.Text = this.GroupName;
        }
    }
}
