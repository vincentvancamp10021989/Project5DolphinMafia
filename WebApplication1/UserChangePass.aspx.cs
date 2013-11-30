using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses.Login.linq;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Connection;

namespace WebApplication1
{
    public partial class UserChangePass : System.Web.UI.Page
    {
        LambdaLecturers lecturer;
        int lecturerId;
        string lecturerPass;
        string LOGOUT = "logout.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session[SessionEnum.SessionNames.LecturorsID.ToString()].Equals(string.Empty))
                {
                    Response.Redirect(LOGOUT);
                }
                else
                {
                    lecturerId = int.Parse(Session[SessionEnum.SessionNames.LecturorsID.ToString()].ToString());
                    lecturer = new LambdaLecturers(lecturerId);
                    lecturerPass = lecturer.GetPasswordFromId();
                }
            }
            catch
            {
                Response.Redirect(LOGOUT);
            }

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (lecturerPass.Equals(Hash.Password_Encryption_md5(tbOld.Text)))
            {
                if (tbNew1.Text.Equals(tbNew2.Text))
                {
                    lecturer.ChangePasswordFromId(tbNew1.Text);
                    lblerror.Text = "Uw paswoord is veranderd!";
                }
                else
                {
                    lblerror.Text = "Uw nieuwe paswoorden komen niet overeen!";
                    
                }
            }
            else
            {
                lblerror.Text = "Uw oud paswoord klopt niet!";
            }
            tbOld.Text = "";
            tbNew1.Text = "";
            tbNew2.Text = "";
            lblerror.Visible = true;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("SlotsView.aspx");
        }
    }
}