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
            bool stupidUserWithAdminRights = false;
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
                        stupidUserWithAdminRights = p.isMaster == 1 ? true : false;
                        if (stupidUserWithAdminRights)
                            UMGMT.Visible = true;
                        break;
                    }

                }
            }
            else
            {
                uName.Text = "Awesome :P";
                AddTop.Visible = false;
            }

            foreach (Topic t in MvcApplication.ent.Topics)
            {
             
                
                Label l1 = new Label();
                l1.Text = "Autor: " + t.Autor + "<br>";
                Label l2 = new Label();
                l2.Text = "Data: " + t.CreationDate.ToString() + "<br>";
                Label l3 = new Label();
                l3.Text = "Titlu: " + t.TopicName + "<br>";

                LinkButton dl = new LinkButton();
                dl.Text = "Delete";
                dl.CommandName = t.Id.ToString();
                dl.Click += Dl_Click; ;

                Label space = new Label();
                space.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";

                LinkButton lb = new LinkButton();
                lb.Text = "---><br><br>";
                lb.CommandName = t.Id.ToString();
                lb.Click += Lb_Click;


                TopicsPanel.ContentTemplateContainer.Controls.Add(l1);
                TopicsPanel.ContentTemplateContainer.Controls.Add(l2);
                TopicsPanel.ContentTemplateContainer.Controls.Add(l3);
                if (stupidUserWithAdminRights)
                {
                    TopicsPanel.ContentTemplateContainer.Controls.Add(dl);
                    TopicsPanel.ContentTemplateContainer.Controls.Add(space);
                }
                TopicsPanel.ContentTemplateContainer.Controls.Add(lb);
                


            }
        }

        private void Dl_Click(object sender, EventArgs e)
        {
            int currentTopicID = int.Parse(((LinkButton)sender).CommandName);
            List<Message> toBeDeleted = new List<Message>();
            toBeDeleted = MvcApplication.ent.Messages.Where<Message>(temp => temp.TopicID == currentTopicID).ToList<Message>();
            foreach (Message item in toBeDeleted)
            {
                MvcApplication.ent.Messages.Remove(item);
            }
            Topic t = MvcApplication.ent.Topics.Where<Topic>(select => select.Id == currentTopicID).First<Topic>();
            MvcApplication.ent.Topics.Remove(t);
            MvcApplication.ent.SaveChanges();
            Response.Redirect("~/MainPage.aspx");

        }

        private void Lb_Click(object sender, EventArgs e)
        {
        
            Response.Redirect("~/Discuss.aspx?topicID=" + ((LinkButton)sender).CommandName);
        }

        private void CurrentTopic_Load(object sender, EventArgs e)
        {
           
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

        protected void UMGMT_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserController.aspx");
        }
    }
}