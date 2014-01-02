using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Ports;  // for COM port access  
using System.IO;        // for file-RW
using System.Net;       // dunno.. yet

namespace Swish1o
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnOn1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        serialWrite("on1");
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //protected void btnOn2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        serialWrite("on2");
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //protected void btnOnAll_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        serialWrite("onall");
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //protected void btnOff1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        serialWrite("off1");
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //protected void btnOff2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        serialWrite("off2");
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //protected void btnOffAll_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        serialWrite("offall");
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
        private bool serialWrite(string data)
        {
            // connect to arduino
            SerialPort port = new SerialPort("COM4", 9600);
            try
            {
                //un-comment this line to cause the arduino to re-boot when the serial connects
                //port.DtrEnabled = true;
                //ways to permanently disable auto-reboot:
                //http://playground.arduino.cc/Main/DisablingAutoResetOnSerialConnection
                port.Open();
                port.Write(data);
                return true;
            } 
            catch (Exception)
            {
                return false;
                //alert the user that we could not connect to the serial port
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                serialWrite("onall");
            }
            catch (Exception)
            {
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                serialWrite("offall");
            }
            catch (Exception)
            {
            }
        }

        //protected void btnLedtest_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (serialWrite("ledtest") == true) { TextBox1.Text = "test OK!"; }
        //        else { TextBox1.Text = "test FAILED!"; }
        //    }
        //    catch (Exception ex)
        //    {
        //        TextBox1.Text += "exception:\n" + ex.Message; 
        //    }


        //}
    }
}
