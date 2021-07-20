﻿using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.StateForms
{
    public partial class Add : Form
    {
        private IStateService _stateService;
        public Add()
        {
            InitializeComponent();
            this._stateService = InstanceFactory.GetInstance<IStateService>(new BusinessModule());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new state will be added.",
                Ok = AddState,
                Cancel = Cancel
            });
        }

        private void AddState()
        {
            this._stateService.Add(new State
            {
                Id = this._stateService.GetNextId(),
                Name = tbxName.Text
            });
        }

        private void Cancel() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}