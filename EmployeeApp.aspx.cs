using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jason_LLC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        EmployeeContacts ec = new EmployeeContacts();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

       
        protected void Submit_Click(object sender, EventArgs e)
        {
            ec.name = Name.Text;
            ec.Address = Address.Text;
            ec.city = City.Text;
            ec.state = State.Text;
            ec.zip = Zip.Text;
            ec.PhoneNumber = PhoneNumber.Text;
            ec.employer = PositionDrop.Text;
            ec.StartDate = StartDate.Text;
            ec.EndDate = EndDate.Text;
            ec.WorkPhone = WorkPhone.Text;
            ec.WorkAddress = WorkAddress.Text;
            ec.WorkCity = WorkCity.Text;
            ec.WorkZip = WorkZip.Text;
            ec.WorkState = WorkState.Text;
            ec.WorkPosition = WorkPos.Text;
            ec.Supervisor = Sup.Text;
            ec.ReasonForLeave = RFL.Text;

            bool succes = ec.Insert(ec);

            if (succes == true)
            {
                Response.Write("successful");

            }

            else
            {
                Response.Write(" Not successful");
            }




        }
    }
}