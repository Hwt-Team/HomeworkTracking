using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsUI.Utilities
{
    public  class MainHelper
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

        public static void SortColumnsOfDgw(DataGridView dgw, params string[] columnNames)
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                dgw.Columns[columnNames[i]].DisplayIndex = i;
            }
        }

        public static void HideColumnsOfDgw(DataGridView dgw, params string[] columnNames)
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                dgw.Columns[columnNames[i]].Visible = false;
            }
            
        }
    }
}
