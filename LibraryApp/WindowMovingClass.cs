using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public static class WindowMovingClass
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hm, int b, int j, int f);

        public static void MouseControl(System.IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, 0x112, 0xf012, 0);
        }
    }
}
