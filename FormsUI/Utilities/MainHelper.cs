using System;
using System.Windows.Forms;

namespace FormsUI.Utilities
{
    public class MainHelper
    {
        public static void SetHelperFormName(Panel panel, Label lbl)
        {
            var name = panel.Name.Substring(panel.Name.IndexOf("panel") + 5);

            string result = "";

            for (int i = 0; i < name.Length - 1; i++)
            {
                result += name[i];
                if (char.IsUpper(name[i + 1])) result += " ";
            }

            result += name[name.Length - 1];

            lbl.Text = result;
        }
    }
}
