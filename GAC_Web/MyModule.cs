using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Configuration;
using System.IO;
using System.Text;

namespace Swish1o
{
    
    /// <summary>
    /// whole module deprecated. NeatUpload provides this functionality now
    /// </summary>
 
    public class MyModule : IHttpModule
    {
        // To avoid using JS for filename
        public static string filename;

        public void Init(HttpApplication app)
        {
            app.BeginRequest += new EventHandler(app_BeginRequest);

        }
        void app_BeginRequest(object sender, EventArgs e)
        {
            HttpContext context = ((HttpApplication)sender).Context;

            if (context.Request.ContentLength > 4096000)
            {
                IServiceProvider provider = (IServiceProvider)context;
                HttpWorkerRequest wr = (HttpWorkerRequest)provider.GetService(typeof(HttpWorkerRequest));
                FileStream fs = null;
                // Check if body contains data
                if (wr.HasEntityBody())
                {
                    // get the total body length
                    int requestLength = wr.GetTotalEntityBodyLength();
                    // Get the initial bytes loaded
                    //int initialBytes = wr.GetPreloadedEntityBody().Length;
                    int initialBytes = wr.GetPreloadedEntityBodyLength(); //Zero reference fix

                    if (!wr.IsEntireEntityBodyIsPreloaded())
                    {
                        byte[] buffer = new byte[512000];
                        //string[] fileName = context.Request.QueryString["fileName"].Split(new char[] { '\\' });
                        //fs = new FileStream(context.Server.MapPath("~/Uploads/" + fileName[fileName.Length - 1]), FileMode.CreateNew);
                         //no need to use server context mapping when you know the path
                        //fs = new FileStream("C:/LANRW/" + filename, FileMode.CreateNew);
                        fs = new FileStream("C:/LANRW/file", FileMode.CreateNew);
                         //Set the received bytes to initial bytes before start reading
                        int receivedBytes = initialBytes;
                        while (requestLength - receivedBytes >= initialBytes)
                        {
                            // Read another set of bytes
                            initialBytes = wr.ReadEntityBody(buffer, buffer.Length);
                            // Write the chunks to the physical file
                            fs.Write(buffer, 0, buffer.Length);
                            // Update the received bytes
                            receivedBytes += initialBytes;
                        }
                        initialBytes = wr.ReadEntityBody(buffer, requestLength - receivedBytes);

                    }
                }
                fs.Flush();
                fs.Close();
                //context.Response.Redirect("UploadFinished.aspx");
            }

        }
        public void Dispose()
        {
        }
    }
}