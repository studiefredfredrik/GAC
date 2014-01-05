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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputFile1.HasFile)
                {
                    InputFile1.MoveTo("C:/LANRW/" + InputFile1.FileName, MoveToOptions.Overwrite);
                }
            }
            catch (Exception)
            {
            }

        }
    }

}