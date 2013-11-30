using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Login.linq;

namespace WebApplication1
{
    public partial class RegistrationView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private LambdaLecturers lambdaLecturers;
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (textBoxPasswoord.Text.Equals(textBoxpwdherh.Text))
            {
                this.lambdaLecturers = new LambdaLecturers(this.textBoxEmail.Text, this.textBoxPasswoord.Text, this.textBoxNaam.Text, this.textBoxAchternaam.Text);
                if (this.lambdaLecturers.GetCheckEmailAP())
                {
                    if (!this.lambdaLecturers.GetCheckExistEmail())
                        this.lambdaLecturers.SetLecturersInsertData();
                    Response.Redirect("loginview.aspx");
                }
            }
            else
            {
                errorLabel.Visible = true;
            }

        }
    }
}