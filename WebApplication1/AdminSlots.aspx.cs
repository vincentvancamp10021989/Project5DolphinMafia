using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses.Slots.linq;

namespace WebApplication1
{
    public partial class AdminSlots : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private LambdaSlots lambdaSlots;
        protected void btnAddSlot_Click(object sender, EventArgs e)
        {
            this.lambdaSlots = new LambdaSlots(this.txtboxDate.Text, this.txtboxStart.Text, this.txtboxEnd.Text, this.txtboxDuration.Text, int.Parse(this.txtboxCapacity.Text), int.Parse(this.txtboxReserved.Text), byte.Parse(this.RadioButtonList1.SelectedItem.Value, System.Globalization.NumberStyles.AllowDecimalPoint),this.DropDownList1.SelectedItem.Value);
            this.lambdaSlots.SetDataInsert();
            Response.Redirect("AdminSlots.aspx");
        }

        protected void txtboxCapacity_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}