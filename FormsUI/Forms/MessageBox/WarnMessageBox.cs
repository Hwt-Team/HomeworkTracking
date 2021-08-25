using System;
using System.Windows.Forms;
using Core.DependencyResolvers.Ninject;
using FormsUI.DependencyResolvers;

namespace FormsUI.Forms.MessageBox
{
    public partial class WarnMessageBox : Form
    {
        private static WarnMessageBox _form;
        private DialogResult _dialogResult;
        private Action _ok;
        private Action _cancel;

        public static WarnMessageBox MessageBox
        {
            get
            {
                _form = InstanceFactory.GetInstance<WarnMessageBox>(new FormModule());
                return _form;
            }
        }

        public WarnMessageBox()
        {
            InitializeComponent();
        }

        public void SetCaption(string caption)
        {
            _form.Text = caption;
        }

        public void SetTitle(string title)
        {
            _form.lblTitle.Text = title;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this._dialogResult = DialogResult.OK;
            DoSomething(_ok, _cancel);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._dialogResult = DialogResult.Cancel;
            DoSomething(_ok, _cancel);
        }

        public void DoSomething(Action ok, Action cancel)
        {
            switch (this._dialogResult)
            {
                case DialogResult.OK:
                    ok.Invoke();
                    Cancel();
                    break;
                case DialogResult.Cancel:
                    cancel.Invoke();
                    Cancel();
                    break;
            }
        }

        public void Cancel()
        {
            this.Close();
        }

        private void SetVisibility(bool value)
        {
            btnOk.Visible = value;
            btnCancel.Visible = value;
        }

        public void Execute(MessageBoxParameter parameter)
        {
            this.SetVisibility(false);
            this.SetCaption(parameter.Caption);
            this.SetTitle(parameter.Title);
            this.Show();
        }

        public void ExecuteOption(MessageBoxOptionParameter parameter)
        {
            this.SetVisibility(true);
            this.SetCaption(parameter.Caption);
            this.SetTitle(parameter.Title);
            this.Show();
            _ok = parameter.Ok;
            _cancel = parameter.Cancel;
        }

        public void ExecuteAsDialog(MessageBoxParameter parameter)
        {
            this.SetVisibility(false);
            this.SetCaption(parameter.Caption);
            this.SetTitle(parameter.Title);
            this.ShowDialog();
        }

        public void ExecuteOptionAsDialog(MessageBoxOptionParameter parameter)
        {
            this.SetVisibility(true);
            this.SetCaption(parameter.Caption);
            this.SetTitle(parameter.Title);
            this.ShowDialog();
            _ok = parameter.Ok;
            _cancel = parameter.Cancel;
        }

    }
}
