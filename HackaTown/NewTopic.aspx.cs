using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackaTown
{
    public partial class NewTopic : System.Web.UI.Page
    {
        int id_to_be_creat = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            foreach (Topic item in MvcApplication.ent.Topics)
            {
                if (item.Id > id_to_be_creat)
                    id_to_be_creat = item.Id;

            }
            id_to_be_creat++;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Topic item = new Topic();
            HttpCookie userIdCookie = new HttpCookie("User");
            item.Autor = Request.Cookies["User"]["Email"];
            item.CreationDate = DateTime.Now;
            item.TopicName = Titl.Text;
           // item.Id = id_to_be_creat;
           

            MvcApplication.ent.Topics.Add(item);
            MvcApplication.ent.SaveChanges();
            id_to_be_creat++;
            Response.Redirect("~/MainPage.aspx");
        }

        protected void Titl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}