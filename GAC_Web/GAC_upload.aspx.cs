using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Configuration;
using System.IO;
using System.Text;
using Brettle;
using Brettle.Web;
using Brettle.Web.NeatUpload;

namespace Swish1o
{
    // GAC_upload 
    // Using the improved Upload-form from AjaxControlToolkit 
    // http://stephenwalther.com/archive/2013/04/30/april-2013-release-of-the-ajax-control-toolkit
    // It  provides chunking of uploads, and as such avoids both the 2gb and the 4gb limits.
    // Nuget install with the command: "Install-Package AjaxControlToolkit"
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void AjaxFileUpload1_UploadComplete(object sender, AjaxControlToolkit.AjaxFileUploadEventArgs e)
        {
            // Save uploaded file to App_Data folder
            //AjaxFileUpload1.SaveAs(MapPath("~/App_Data/" + e.FileName));

            // We are saving the files to our shared dir with RW privileges in stead of the web-root
            AjaxFileUpload1.SaveAs("C:\\lanrw\\" + e.FileName);
        } 
    }

}