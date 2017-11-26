using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackaTown
{
    public partial class Discuss : System.Web.UI.Page
    {
        int currentTopicID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            bool stupidUserWithAdminRights = false;
            String s = Request.QueryString["topicID"];
            tID.Text = s;

            string userSettings = "";
            if (Request.Cookies["User"]["Email"] != null)
            { userSettings = Request.Cookies["User"]["Email"]; }

            foreach (Person p in MvcApplication.ent.Persons)
            {
                if (p.Email == userSettings)
                {
                    stupidUserWithAdminRights = p.isMaster == 1 ? true : false;
                    break;
                }

            }

            if (s == null)
            {
                return;
            }
            currentTopicID = int.Parse(s);
            foreach (Topic item in MvcApplication.ent.Topics)
            {
                if (int.Parse(s) == item.Id)
                {
                    TName.Text = item.TopicName.ToString();
                    TData.Text = item.CreationDate.ToString();
                    break;
                }
            }
            foreach (Message item in MvcApplication.ent.Messages.Where<Message>(t=>t.TopicID == currentTopicID))
            {
                // Trebuie sa iau mesajele anterioare si sa le afisez aici

                Label l2 = new Label();
                l2.Text = "<br>Autor: " + item.Author + "<br>";
                Label l3 = new Label();
                l3.Text = "Data: " + item.Date.ToString() + "<br>";
                Label l4 = new Label();
                l4.Text = "Message: " + item.Message1 + "<br>";

                LinkButton dl = new LinkButton();
                dl.Text = "Delete";
                dl.CommandName = item.Id.ToString();
                dl.Click += Dl_Click;

                Label newLine = new Label();
                newLine.Text = "<br>";

                TopicsPanel.ContentTemplateContainer.Controls.Add(l2);
                TopicsPanel.ContentTemplateContainer.Controls.Add(l3);
                TopicsPanel.ContentTemplateContainer.Controls.Add(l4);
                if (stupidUserWithAdminRights)
                {
                    TopicsPanel.ContentTemplateContainer.Controls.Add(dl);
                    TopicsPanel.ContentTemplateContainer.Controls.Add(newLine);
                }
            }

        }
        
        private void Dl_Click(object sender, EventArgs e)
        {
            int currentMessageID = int.Parse(((LinkButton)sender).CommandName);
            Message toBeDeleted = MvcApplication.ent.Messages.Where<Message>(temp => temp.Id == currentMessageID).First<Message>();
            MvcApplication.ent.Messages.Remove(toBeDeleted);
            MvcApplication.ent.SaveChanges();
            Response.Redirect("~/Discuss.aspx?topicID=" + currentTopicID);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Message m = new Message();
            HttpCookie userIdCookie = new HttpCookie("User");
            m.Author = Request.Cookies["User"]["Lname"] + ' ' + Request.Cookies["User"]["Fname"];
            m.Date = DateTime.Now;
            m.Message1 = WriteMessageTextBox.Text;
            // m.Title = ;   //trebuie sa iau numele Title din sender
            m.TopicID = currentTopicID;


            MvcApplication.ent.Messages.Add(m);
            MvcApplication.ent.SaveChanges();
            Response.Redirect("~/Discuss.aspx?topicID=" + currentTopicID );
        }
    }
}