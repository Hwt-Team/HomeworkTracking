using System.Linq;
using System.Windows.Forms;

namespace FormsUI.Forms.LoginForms
{
    public static class ValidateHelper
    {
        public static void SetErrorMessage(string message, Control errorTextBox)
        {
            //this.lblErrorMessage.Text = "       " + message;
            //this.lblErrorMessage.Visible = true;

            errorTextBox.Text = "       " + message;
            errorTextBox.Visible = true;
        }

        public static bool CheckChanged(string currentText, string previousText)
        {
            return currentText != previousText;
        }

        public static void ErrorMessageSetter(string message, Control errorTextBox)
        {
            SetErrorMessage("Please, enter " + message + ".", errorTextBox);
        }

        public static bool ValidateSetter(ValidationModel model, Control errorTextBox)
        {
            if (CheckChanged(model.CurrentText, model.PreviousText)) return false;
            ErrorMessageSetter(model.Message, errorTextBox);
            return true;
        }

        public static bool ChangedValidation(Control textBox, params ValidationModel[] models)
        {
            if (models.Any(model => ValidateSetter(model, textBox))) return false;

            textBox.Visible = false;
            return true;
        }

        public static bool CheckPass(string pass, string repeat, string message, Control textBox)
        {
            if (!(pass == repeat))
            {
                SetErrorMessage(message, textBox);
                return false;
            }

            textBox.Visible = false;
            return true;
        }

        public static bool ValidateAll(string pass, string repeat, string message, Control textBox, params ValidationModel[] models)
        {
            bool result = true;
            if (!ChangedValidation(textBox, models)) result = false;

            if (!CheckPass(pass, repeat, message, textBox)) result = false;

            return result;
        }
    }
}
