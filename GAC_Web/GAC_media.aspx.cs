using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Swish1o
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[] fileList;
        string[] dirList;
        string rootDir = "C:/LANRW";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                update_listBox(rootDir);
            }
        }
        private void update_listBox(string gotoDir)
        {
            try
            {
                fileList = Directory.GetFiles(gotoDir);
                dirList = Directory.GetDirectories(gotoDir);

                ListBox1.Items.Add(new ListItem("...Back to Root Dir...", rootDir, true));
                foreach (string dir in dirList)
                {
                    ListBox1.Items.Add(new ListItem(dir, dir, true));
                }
                foreach (string file in fileList)
                {
                    if (file.EndsWith(".mp3") || file.EndsWith(".avi") || file.EndsWith(".mp4") ||
                        file.EndsWith(".mkv") || file.EndsWith(".m3u")) // add more filetypes 
                    {
                        ListBox1.Items.Add(new ListItem(file, file, true));
                    }
                    else
                    {
                        ListBox1.Items.Add(new ListItem(file, file, false));
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        protected void btnOpen_Click(object sender, EventArgs e)
        {
            string item = ListBox1.SelectedValue;
            bool itemEnabled = ListBox1.SelectedItem.Enabled;
            if (Directory.Exists(item))
            {
                ListBox1.Items.Clear();
                update_listBox(item);
            }
            else if (File.Exists(item) &&
                itemEnabled)
            {
                System.Diagnostics.Process.Start(item);
            }
        }

        protected void Button1_Click(object sender, EventArgs e) // vol+
        {
            VolumeController.VolumeUp();
        }

        protected void Button2_Click(object sender, EventArgs e) // vol-
        {
            VolumeController.VolumeDown();
        }

        protected void btnMute_Click(object sender, EventArgs e) // mute
        {
            VolumeController.Mute();
        }

        protected void btnPause_Click(object sender, EventArgs e) // pause
        {
            //VolumeController.Pause();
            VolumeController.Spacebar();
        }

        protected void btnClose_Click(object sender, EventArgs e) // close
        {
            ProcControl.killVlc();
        }
        
    }
}