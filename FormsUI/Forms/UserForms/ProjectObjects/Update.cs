using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.ProjectObjects
{
    public partial class Update : Form
    {
        private readonly IProjectObjectService _projectObjectService;

        public int Id { get; set; }
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public string ObjectName { get; set; }

        public Update()
        {
            InitializeComponent();
            this._projectObjectService = InstanceFactory
                .GetInstance<IProjectObjectService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.tbxNamespace.Text = this.Namespace;
            this.tbxClassName.Text = this.ClassName;
            this.tbxObjectName.Text = this.ObjectName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "Changed project object will be updated.",
                Ok = UpdateProjectObject,
                Cancel = Cancel
            });
        }

        private void UpdateProjectObject()
        {
            this._projectObjectService.Update(new ProjectObject
            {
                Id = this.Id,
                NameSpace = this.tbxNamespace.Text,
                ClassName = this.tbxClassName.Text,
                ObjectName = this.tbxObjectName.Text
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
