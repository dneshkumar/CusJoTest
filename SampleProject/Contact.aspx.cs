using SampleProject.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleProject
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string inputUrl = "http://localhost:59568/Api/Values/Post";
                string data = "{ \"username\": " + '"' + txtUsername.Text + '"' + " ,\"email\":" + '"' + txtEmailid.Text.ToString() + '"' + ",\"password\":" + '"' + txtPassword.Text.ToString() + " }";

                string result = CallWebService.POST(inputUrl, data);
                if (result == "success")
                {
                    lblresult.Style.Add("display", "block");
                }
                else
                {
                    lblresult.InnerText = "New User Registration Error";
                    lblresult.Style.Add("display", "block");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     
    }
}