using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackaTown
{
    public partial class UserController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int loggedInUserID;
            try
            {
                loggedInUserID = int.Parse(Request.Cookies["User"]["ID"]);
                Person p = MvcApplication.ent.Persons.Where<Person>(t => t.PersonID == loggedInUserID).First<Person>();
                if (p.isMaster == 0)
                {
                    Label l2 = new Label();
                    l2.Text = "You do not have sufficient privileges to access this webpage. Please contact an administrator.";
                    TopicsPanel.ContentTemplateContainer.Controls.Add(l2);
                    return;
                }
            }
            catch {
                Label l2 = new Label();
                l2.Text = "You do not have sufficient privileges to access this webpage. Please contact an administrator.";
                TopicsPanel.ContentTemplateContainer.Controls.Add(l2);
                return; }
            List<Person> personList = MvcApplication.ent.Persons.Where<Person>(t => t.Email != "DELETED USER").ToList<Person>();
            foreach (Person item in personList)
            {
                // Trebuie sa iau mesajele anterioare si sa le afisez aici

                Label l2 = new Label();
                l2.Text = "<br>Last name: " + item.LastName + "<br>";
                Label l3 = new Label();
                l3.Text = "First name: " + item.FirstName + "<br>";
                Label l4 = new Label();
                l4.Text = "Email: " + item.Email + "<br>";

                LinkButton dl = new LinkButton();
                dl.Text = "Delete user";
                dl.CommandName = item.PersonID.ToString();
                dl.Click += Dl_Click;

                Label space = new Label();
                space.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";

                LinkButton sw = new LinkButton();
                sw.Text = item.isMaster == 1 ? "Switch to user" : "Switch to admin";
                sw.CommandName = item.PersonID.ToString();
                sw.Click += Sw_Click;

                Label newLine = new Label();
                newLine.Text = "<br>";
                
                TopicsPanel.ContentTemplateContainer.Controls.Add(l2);
                TopicsPanel.ContentTemplateContainer.Controls.Add(l3);
                TopicsPanel.ContentTemplateContainer.Controls.Add(l4);
                TopicsPanel.ContentTemplateContainer.Controls.Add(sw);
                TopicsPanel.ContentTemplateContainer.Controls.Add(space);
                TopicsPanel.ContentTemplateContainer.Controls.Add(dl);
                TopicsPanel.ContentTemplateContainer.Controls.Add(newLine);
            }

        }

        private void Sw_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((LinkButton)sender).CommandName);
            Person p = MvcApplication.ent.Persons.Where<Person>(t => t.PersonID == id).First<Person>();
            p.isMaster = p.isMaster == 1 ? 0 : 1;
            MvcApplication.ent.SaveChanges();
            Response.Redirect("~/UserController.aspx");
        }

        private void Dl_Click(object sender, EventArgs e)
        {
            int fuckingUserWantsToBeDeleted_id = int.Parse(((LinkButton)sender).CommandName);
            //Do not delete the fucking USER!!!!!!
            Person p = MvcApplication.ent.Persons.Where<Person>(t => t.PersonID == fuckingUserWantsToBeDeleted_id).First<Person>();
            p.isMaster = 0;
            p.FirstName = "User";
            p.LastName = "Deleted";
            p.Password = "Maieahiii, Maieahuuuu, Maieahaaa, Maieahaha :)";
            p.Email = "DELETED USER";
            MvcApplication.ent.SaveChanges();
            Response.Redirect("~/UserController.aspx");
        }
    }
    
}