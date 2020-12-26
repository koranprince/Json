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
    public partial class Login
    {
        public class OwnerLogin
        {
            public string UserName { get; set; }
            public string Password { get; set; }

            static string mystringconn = ConfigurationManager.ConnectionStrings["JasonConnectionString"].ConnectionString;

            //Selecting all Employee applications
            public DataTable EmployeeApplications(OwnerLogin o)
            {
                

                SqlConnection conn = new SqlConnection(mystringconn);
                DataTable dt = new DataTable();
                try
                {
                    string Val = "Select * from Login Where username = @UserName and Password = @Password";
                    SqlCommand cmd = new SqlCommand(Val, conn);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    adpt.Fill(dt);
                    cmd.Parameters.AddWithValue("@UserName", o.UserName);
                    cmd.Parameters.AddWithValue("@Password", o.Password);
                    conn.Open();






                }

                catch (Exception)
                {


                }
                finally
                {
                    conn.Close();

                }
                return dt;




            }


            //Check if a username exsists and then creates a new    
            public bool ValidateInsert(OwnerLogin o)
            {
                bool InsertSuccess = false;

                SqlConnection conn = new SqlConnection(mystringconn);
                DataTable dt = new DataTable();
                try
                {
                    string Val = "Select * from Login Where username = @UserName and Password = @Password";
                    SqlCommand cmd = new SqlCommand(Val, conn);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@UserName", o.UserName);
                    cmd.Parameters.AddWithValue("@Password", o.Password);
                    //int rows = (int)cmd.ExecuteScalar();
                    adpt.Fill(dt);
                    if (dt.Rows.Count>0)
                    {
                        InsertSuccess = true;
                        
                    }
                    else
                    {
                        InsertSuccess = false;

                    }



                }

                catch (Exception)
                {


                }
                finally
                {
                    conn.Close();

                }
                return InsertSuccess;




            }

            public bool insertLogin(OwnerLogin o)
            {
                bool successful = false;
                SqlConnection conn = new SqlConnection(mystringconn);
                try
                {
                    string insert = "insert into login (UserID,UserName,Password)values ((Select Max(UserID)+1 from Login),@UserName,@Password)";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@UserName", o.UserName);
                    cmd.Parameters.AddWithValue("@Password", o.Password);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        successful = true;

                    }
                   
                }
                catch (Exception)
                {


                }
                finally
                {

                    conn.Close();
                }

                return successful;


            }
        
    
            }

        
    }
}
