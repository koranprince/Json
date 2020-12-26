using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jason_LLC
{
    public partial class Login : System.Web.UI.Page
    {
        OwnerLogin OL = new OwnerLogin();
        protected void Page_Load(object sender, EventArgs e)
        {
            Warn.Visible = false;
            if (!IsPostBack)
            {
                Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();

            }
            else
            {
                Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();

            }

        }

        protected void Page_Init(object sender, EventArgs e)
        {

            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();



        }
       

        protected void LogOut(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OL.UserName = UserName.Text;
            OL.Password = Password.Text;
            bool Success = OL.ValidateInsert(OL);
            
            if (Success is true)
            {
                Response.Redirect("Home.aspx");
                
            }
            else {

                Warn.Visible = true;
                //suc.Visible = true;
            }
        }
    }





}