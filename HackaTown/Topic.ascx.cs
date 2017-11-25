using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackaTown
{
    public partial class Topic1 : System.Web.UI.UserControl
    {
        private DateTime dt;
        private string auth;
        private string tt;
        public DateTime Data
        {
            set {
                try { Dat.Text += value.Day.ToString() + '/' + value.Month.ToString() + '/' + value.Year.ToString(); }
                catch { };
                dt = value;
            }
            get { return dt; }
        }
        public string Autor {
            get { return auth; }
            set { auth += value;
                try { Aut.Text += value; }
                catch { }
            }
        }
        public string Titlu {

            get { return tt; }
            set {tt = value;
                try { Tit.Text += value; }
                catch { }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Panel1_Load(object sender, EventArgs e)
        {
            Dat.Text = dt.Day.ToString() + '/' + dt.Month.ToString() + '/' + dt.Year.ToString();
            Tit.Text = tt;
            Aut.Text = auth;
        }
    }
}