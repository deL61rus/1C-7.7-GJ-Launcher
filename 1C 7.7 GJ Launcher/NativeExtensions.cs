using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace _1C_7._7_GJ_Launcher
{
    public static class NativeExtensions
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void ExitWindowsEx(uint type, uint reason);
    }
}
