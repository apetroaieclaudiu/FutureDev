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
    }
}