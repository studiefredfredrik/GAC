using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Collections;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;

namespace Swish1o
{
    public class VolumeController
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public static void VolumeDown()
        {
            keybd_event((byte)ConsoleKey.VolumeDown, 0, 0, 0); // decrease volume
        }

        public static void VolumeUp()
        {
            keybd_event((byte)ConsoleKey.VolumeUp, 0, 0, 0); // increase volume
        }

        public static void Mute()
        {
            keybd_event((byte)ConsoleKey.VolumeMute, 0, 0, 0); // mute
        }

        public static void Pause()
        {
            keybd_event((byte)ConsoleKey.Pause, 0, 0, 0); // pause
        }
        public static void Spacebar()
        {
            keybd_event((byte)ConsoleKey.Spacebar, 0, 0, 0); // pause
        }
    }
}
