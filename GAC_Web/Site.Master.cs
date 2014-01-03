using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Swish1o
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e) // light switch button  
        {
            Response.Redirect("Default.aspx");
        }


        protected void imgBtnMedia_Click(object sender, ImageClickEventArgs e) // media button
        {
            Response.Redirect("GAC_media.aspx");
        }

        protected void imgBtnUpload_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("GAC_upload.aspx");
        }
    }
}
