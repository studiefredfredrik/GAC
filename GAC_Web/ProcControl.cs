using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace Swish1o
{
    public class ProcControl
    {
        public static void killVlc()
        {
            System.Diagnostics.Process[] procs = null;
            try
            {
                procs = Process.GetProcessesByName("vlc");
                Process vlcProc = procs[0];

                if (!vlcProc.HasExited)
                {
                    vlcProc.Kill();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (procs != null)
                {
                    foreach (Process p in procs)
                    {
                        p.Dispose();
                    }
                }
            }
        }
    }
}