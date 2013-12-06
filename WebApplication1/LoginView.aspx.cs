using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Login.linq;
using System.Windows.Forms;
using WebApplication1.Klasses.Connection;

namespace WebApplication1
{
    public partial class LoginView : System.Web.UI.Page
    {
        private const string NEXT_PAGE_SESSION = "LoginView.aspx";
        private LambdaLecturers lectors;
        private Mail sendMail;
        private const string NEXT_PAGE = "SlotsView.aspx";
        private Entity entity;

        protected void Page_Load(object sender, EventArgs e)
        {
            // this.MoDLabel.Text == lamba hier
            this.ErrorLabel.Visible = false;
            if (this.MoDLabel.Text == "")
            {
                this.MoDLabel.Visible = false;
            }
            else
            {
                this.MoDLabel.Visible = true;
            }
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

                int accessLvl = int.Parse(this.lectors.GetCheckLecturersInfo_DatabaseFields().Access.ToString());
                Session.Add(SessionEnum.SessionNames.AccessLvl.ToString(), accessLvl);
                if (accessLvl == 2)
                {
                    Response.Redirect("AdminMain.aspx");
                }
                else
                {
                    HttpContext.Current.Session.Add(SessionEnum.SessionNames.CampusName.ToString(), "Antwerpen");
                    Response.Redirect(NEXT_PAGE);
                }
            }
            else
            {
                this.ErrorLabel.Visible = true;
                this.textboxPassword.Text = "";
                this.textboxUsername.Text = "";
            }
        }

        protected void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                this.sendMail = new Mail(HttpUtility.HtmlEncode(this.txtBoxMail.Text));
                this.sendMail.SendEmailWithNewPassword();
                this.txtBoxMail.Text = "";
            }
            catch
            {
                Response.Redirect(NEXT_PAGE_SESSION);
            }
        }

        protected void registrerenButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationView.aspx");
        }
    }
}