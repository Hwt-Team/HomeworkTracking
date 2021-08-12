﻿using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using FormsUI.Forms.MessageBox;
using Ninject.Modules;
using System;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.ProjectObjects
{
    public partial class Add : Form
    {
        private readonly IProjectObjectService _projectObjectService;
        public Add()
        {
            InitializeComponent();
            this._projectObjectService = InstanceFactory
                .GetInstance<IProjectObjectService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new project object will be added.",
                Ok = this.AddProjectObject,
                Cancel = this.Cancel
            });
        }

        private void AddProjectObject()
        {
            this._projectObjectService.Add(new ProjectObject
            {
                Id = this._projectObjectService.GetNextId(),
                NameSpace = this.tbxNamespace.Text,
                ClassName = this.tbxClassName.Text,
                ObjectName = this.tbxObjectName.Text
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel() { }

    }
}