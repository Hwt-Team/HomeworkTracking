using System;

namespace FormsUI.Forms.MessageBox
{
    public class MessageBoxOptionParameter : MessageBoxParameter
    {
        public Action Ok { get; set; }
        public Action Cancel { get; set; }
    }
}
