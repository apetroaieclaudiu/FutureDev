using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackaTown
{
    public partial class RegNewUser : System.Web.UI.Page
    {
        int id_to_be_created = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            foreach (Person item in MvcApplication.ent.Persons)
            {
                if (item.PersonID > id_to_be_created)
                    id_to_be_created = item.PersonID;
                
            }
            id_to_be_created++;
            //IdTest.Text = id_to_be_created.ToString();
        }

        protected void LName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SaveBTN_Click(object sender, EventArgs e)
        {
            foreach (Person q in MvcApplication.ent.Persons)
            {
                if (q.Email == Email.Text)
                {
                    return;
                }
            }
            Person p = new Person();
            p.PersonID = id_to_be_created;
            p.FirstName = FName.Text;
            p.LastName = LName.Text;
            p.Email = Email.Text;
            p.Password = Pass.Text;
            p.isMaster = 1;
            MvcApplication.ent.Persons.Add(p);
            MvcApplication.ent.SaveChanges();
            id_to_be_created++;
            Response.Redirect("~/MainPage.aspx");
            //schimba pagina
        }
    }
}