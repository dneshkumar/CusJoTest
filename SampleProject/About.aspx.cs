using Newtonsoft.Json;
using SampleProject.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleProject
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void drpUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                string inputUrl = "http://localhost:59568/Api/Home/Get";
                string resultJson = CallWebService.GET(inputUrl + "/user=" + drpUsers.SelectedValue.ToString());
                if (!string.IsNullOrEmpty(resultJson))
                {
                    List<UserPages> objpages = JsonConvert.DeserializeObject<List<UserPages>>(resultJson);
                    Page1LinkToggle.Checked = objpages[0].page1;
                    Page2LinkToggle.Checked = objpages[0].page2;
                    Page3LinkToggle.Checked = objpages[0].page3;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string inputUrl = "http://localhost:59568/Api/Home/Post";
                UserPages objdata = new UserPages();

                objdata.username = drpUsers.SelectedValue.ToString();
                objdata.page1 = Page1LinkToggle.Checked;
                objdata.page2 = Page2LinkToggle.Checked;
                objdata.page3 = Page3LinkToggle.Checked;

                string data = JsonConvert.SerializeObject(objdata);
                string result = CallWebService.POST(inputUrl, data);
                if (result == "inserted")
                {
                    lblresult.InnerText = "Saved Successfully!!!";
                }
                else if (result == "updated")
                {
                    lblresult.InnerText = "Updated Successfully!!!";
                }
                else
                {
                    lblresult.InnerText = "Error";
                }

                lblresult.Style.Add("display", "block");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


    //class for userpage data serialise and deserialise
    class UserPages
    {
        public string username { get; set; }
        public bool page1 { get; set; }
        public bool page2 { get; set; }
        public bool page3 { get; set; }
    }
}