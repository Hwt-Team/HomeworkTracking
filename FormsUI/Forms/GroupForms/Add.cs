using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.GroupForms
{
    public partial class Add : Form
    {
        private IGroupService _groupService;
        public Add()
        {
            InitializeComponent();
            this._groupService = InstanceFactory.GetInstance<IGroupService>(new BusinessModule());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //var messageBox = InstanceFactory.GetInstance<WarnMessageBox>(new FormModule());
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new group will be added.",
                Ok = AddGroup,
                Cancel = Cancel
            });
        }

        private void AddGroup()
        {
            this._groupService.Add(new Group
            {
                Id = this._groupService.GetNextId(),
                Name = tbxName.Text
            });
        }

        private void Cancel()
        {
            //this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
