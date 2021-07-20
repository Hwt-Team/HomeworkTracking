﻿using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.Forms.MessageBox;

namespace FormsUI.Forms.ExerciseForms
{
    public partial class Add : Form
    {
        private IExerciseService _exerciseService;

        public Add()
        {
            InitializeComponent();
            this._exerciseService = InstanceFactory.GetInstance<IExerciseService>(new BusinessModule());
        }

        private void SetDatetimeValue()
        {
            dtpDeadline.MinDate = DateTime.Now;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            SetDatetimeValue();
            SetDatetimePickerFormat();
        }

        private void SetDatetimePickerFormat()
        {
            dtpDeadline.Format = DateTimePickerFormat.Custom;
            dtpDeadline.ShowUpDown = true;
            dtpDeadline.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WarnMessageBox.MessageBox.ExecuteOption(new MessageBoxOptionParameter
            {
                Caption = "System",
                Title = "A new exercise will be added.",
                Ok = AddExercise,
                Cancel = Cancel
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel() { }

        private void AddExercise()
        {
            this._exerciseService.Add(new Exercise
            {
                Id = this._exerciseService.GetNextId(),
                Title = tbxTitle.Text,
                Deadline = dtpDeadline.Value == DateTime.Now 
                    ? (DateTime?) null
                    : dtpDeadline.Value
            });
        }
    }
}