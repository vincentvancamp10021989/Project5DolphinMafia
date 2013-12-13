using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses.Slots.linq;
using WebApplication1.Klasses;

namespace WebApplication1
{
    public partial class AdminSlots : System.Web.UI.Page
    {
        string LOGOUT = "Logout.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session[SessionEnum.SessionNames.AccessLvl.ToString()].Equals(string.Empty) ||
                    !(Session[SessionEnum.SessionNames.AccessLvl.ToString()].Equals(2)))
                    Response.Redirect(LOGOUT);
            }
            catch
            {
                HttpContext.Current.Response.Redirect(LOGOUT);
            }
        }

        private LambdaSlots lambdaSlots;
        // Reserved is weg, dus deze code aanpassen!
       protected void btnAddSlot_Click(object sender, EventArgs e)
      {
          try
          {
              this.lambdaSlots = new LambdaSlots(this.txtboxDate.Text, this.txtboxStart.Text, this.txtboxEnd.Text, this.txtboxDuration.Text, int.Parse(this.txtboxCapacity.Text), this.RadioButtonList1.SelectedIndex, this.DropDownList1.SelectedItem.Value);
              this.lambdaSlots.SetDataInsert();
              Response.Redirect("AdminSlots.aspx");
              
          }
          catch (Exception)
          {
              errorLbl.Visible = true;
          }
          
            
       }

        protected void txtboxCapacity_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void terugBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMain.aspx");
        }
    }
}