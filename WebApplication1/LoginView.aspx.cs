using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Login.linq;

namespace WebApplication1
{
    public partial class LoginView : System.Web.UI.Page
    {
        private const string NEXT_PAGE_SESSION = "LoginView.aspx";
        private LambdaLecturers lectors;
        private Mail sendMail;
        private const string NEXT_PAGE = "SlotsView.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()].Equals(string.Empty))
                    HttpContext.Current.Response.Redirect(NEXT_PAGE);
            }
            catch { }
        }

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
              this.lectors = new LambdaLecturers(HttpUtility.HtmlEncode(this.textboxUsername.Text), HttpUtility.HtmlEncode(this.textboxPassword.Text));
              if (this.lectors.GetCheckLectorInfo())
              {
                  HttpContext.Current.Session.Add(SessionEnum.SessionNames.LecturorsID.ToString(), this.lectors.GetCheckLecturersInfo_DatabaseFields().ID);
                  HttpContext.Current.Response.Redirect(NEXT_PAGE);
              }
        }

        protected void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                this.sendMail = new Mail(this.txtBoxMail.Text);
                this.sendMail.SendEmailWithNewPassword();
                this.txtBoxMail.Text = "";
            }
            catch { }
        }
    }
}