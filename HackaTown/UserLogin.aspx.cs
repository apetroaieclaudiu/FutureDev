using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackaTown
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            foreach (Person p in MvcApplication.ent.Persons)
            {  
                if (p.Email == Email.Text)
                {
                    if (p.Password == Pass.Text)
                    {
                        HttpCookie userIdCookie = new HttpCookie("User");
                        userIdCookie["Email"] = Email.Text;
                        userIdCookie["Pass"] = Pass.Text;
                        userIdCookie["Fname"] = p.FirstName;
                        userIdCookie["Lname"] = p.LastName;
                        Response.Cookies.Add(userIdCookie);
                        Response.Redirect("~/MainPage.aspx");
                    }
                    else
                    { }
                    break;
                }   
            }
        }
    }
}