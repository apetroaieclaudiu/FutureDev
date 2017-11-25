using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackaTown
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            Sign.Text = "Log in";
            if (Request.Cookies["User"] != null)
            {
                Sign.Text = "Sign Out";
                SupButton.Visible = false;
                string userSettings = "";
                if (Request.Cookies["User"]["Email"] != null)
                { userSettings = Request.Cookies["User"]["Email"]; }

                foreach (Person p in MvcApplication.ent.Persons)
                {
                    if (p.Email == userSettings)
                    {
                        uName.Text = p.FirstName + ' ' + p.LastName;
                        break;
                    }
                    
                }
            }
            else
                uName.Text = "Awesome :P";

            foreach (Topic t in MvcApplication.ent.Topics)
            {
                Topic1 currentTopic = new Topic1();
                
                Label l1 = new Label();
                l1.Text = "Autor: " + t.Autor + "<br>";
                Label l2 = new Label();
                l2.Text = "Data: " + t.CreationDate.ToString() + "<br>";
                Label l3 = new Label();
                l3.Text = "Titlu: " + t.TopicName + "<br><br>";
                TopicsPanel.ContentTemplateContainer.Controls.Add(l1);
                TopicsPanel.ContentTemplateContainer.Controls.Add(l2);
                TopicsPanel.ContentTemplateContainer.Controls.Add(l3);
                
            }
            //  this.Construct();
        }

        private void CurrentTopic_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null)
            {
                HttpCookie myCookie = new HttpCookie("User");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Request.Cookies["User"]["Email"] = null;
                Response.Cookies.Add(myCookie);
                Response.Redirect("~/MainPage.aspx");
            }
            Response.Redirect("~/UserLogin.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/RegNewUser.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NewTopic.aspx");
        }
    }
}