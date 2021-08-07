using System;
using System.Reflection;
using System.Windows.Forms;
using FormsUI.Forms.LoginForms;
using FormsUI.Forms.MainMenu;
using FormsUI.Forms.MessageBox;

namespace FormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaseForm());
        }
    }
}
