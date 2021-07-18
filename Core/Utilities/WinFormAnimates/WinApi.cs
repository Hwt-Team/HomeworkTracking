using System;
using System.Runtime.InteropServices;

namespace FormsUI
{
    public class WinApi
    {
        public const int HorizontalPositive = 0X1;
        public const int HorizontalNegative = 0X2;
        public const int VerticalPositive = 0X4;
        public const int VerticalNegative = 0X8;
        public const int Center = 0X10;
        public const int Blend = 0X80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}
