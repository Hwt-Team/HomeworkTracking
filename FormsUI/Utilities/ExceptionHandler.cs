using FormsUI.Forms.MessageBox;
using System;

namespace FormsUI.Utilities
{
    public static class ExceptionHandler
    {
        public static void Handle(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                WarnMessageBox.MessageBox.Execute(new MessageBoxParameter 
                {
                    Caption = "System",
                    Title = exception.Message
                });
            }
        }

        public static void HandleWithCatch(Action forTry, Action forCatch)
        {
            try
            {
                forTry.Invoke();
            }
            catch (Exception exception)
            {
                forCatch.Invoke();
                WarnMessageBox.MessageBox.Execute(new MessageBoxParameter
                {
                    Caption = "System",
                    Title = exception.Message
                });
            }
        }
    }
}
