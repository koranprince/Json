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
        class EmployeeContacts
        {
            //Getter Setter Properties
            //Acts as Data Carrier in Website
            public string EmployeeID { get; set; }
            public string name { get; set; }
            public string Address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zip { get; set; }
            public string PhoneNumber { get; set; }
            public string employer { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public string WorkPhone { get; set; }
            public string WorkAddress { get; set; }
            public string WorkCity { get; set; }
            public string WorkZip { get; set; }
            public string WorkState { get; set; }
            public string WorkPosition { get; set; }
            public string Supervisor { get; set; }
            public string ReasonForLeave { get; set; }
            //public int EmployeeID { get; set; }

            static string myconnstrng = ConfigurationManager.ConnectionStrings["JasonConnectionString"].ConnectionString;
            //Selecting Data From Database
            public DataTable Select()
            {
                //Create Connection
                SqlConnection conn = new SqlConnection(myconnstrng);
                DataTable dt = new DataTable();

                try
                {
                    //To select Data from Database
                    string Empl = " Select * From EmployeeInfo";
                    //Creating cmd using Empl and conn
                    SqlCommand cmd = new SqlCommand(Empl, conn);
                    //Creating SQL Dataadapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception )
                {

                }
                finally
                {
                    conn.Close();
                }
                return dt;
            }
            public bool Insert(EmployeeContacts c)
            {
                bool isSuccess = false;

                
                //ConnectionState to database
                SqlConnection conn = new SqlConnection(myconnstrng);
                try
                {
                    //Query to insert
                    string Empl = "Insert into EmployeeInfo(EmployeeID,Name,Address,City,State,Zip,PhoneNumber,Position,StartDate,EndDate,WorkPhone,WorkAddress,WorkCity,WorkState,WorkZip,WorkPos,Supervisor,ReasonForLeaving)" +
                        //",Address,City,State,Zip,PhoneNumber,Position,StartDate," +
                        // "EndDate,WorkPhone,WorkAddress,WorkCity,WorkState,WorkZip,WorkPos,Supervisor,ReasonForLeaving) " +
                        "Values(91,@Name,@Address,@City,@State,@Zip,@PhoneNumber,@Position,@StartDate,@EndDate,@WorkPhone,@WorkAddress,@WorkCity,@WorkState,@WorkZip,@WorkPos,@Supervisor,@ReasonForLeaving)";
                        //",@Address,@City,@State,@Zip,@PhoneNumber,@Position,@StartDate,@EndDate,@WorkPhone,@WorkAddress,@WorkCity,@WorkState,@WorkZip,@WorkPos,@Supervisor,@ReasonForLeaving) ";
                    SqlCommand cmd = new SqlCommand(Empl, conn);
                    //Creating SQL Dataadapter using cmd
                    //Creating Paramaters to add data
                    cmd.Parameters.AddWithValue("@Name", c.name);
                    cmd.Parameters.AddWithValue("@Address", c.Address);
                    cmd.Parameters.AddWithValue("@City", c.city);
                    cmd.Parameters.AddWithValue("@State", c.state);
                    cmd.Parameters.AddWithValue("@Zip", c.zip);
                    cmd.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Position", c.employer);
                    cmd.Parameters.AddWithValue("@StartDate", c.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", c.EndDate);
                    cmd.Parameters.AddWithValue("@WorkPhone", c.WorkPhone);
                    cmd.Parameters.AddWithValue("@WorkAddress", c.WorkAddress);
                    cmd.Parameters.AddWithValue("@WorkCity", c.WorkCity);
                    cmd.Parameters.AddWithValue("@WorkState", c.WorkState);
                    cmd.Parameters.AddWithValue("@WorkZip", c.WorkZip);
                    cmd.Parameters.AddWithValue("@WorkPos", c.WorkPosition);
                    cmd.Parameters.AddWithValue("@Supervisor", c.Supervisor);
                    cmd.Parameters.AddWithValue("@ReasonForLeaving", c.ReasonForLeave);
                    //open connection
                    //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }

                    else
                    {
                        isSuccess = false;
                    }
                }
                catch(Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
                return isSuccess;

               
            }
            //public bool Update(WebForm1 c)
            //{
            //    bool isSuccess = false;
                

            //    //ConnectionState to database
            //    SqlConnection conn = new SqlConnection(myconnstrng);
            //    try
            //    {
            //        //Query to insert
            //        string Empl = "Update EmployeenInfo SET Name=@Name,Address=@Address,City=@City,State=@State,Zip=@Zip,PhoneNumber=@PhoneNumber,Position=@Position,StartDate=@StartDate," +
            //            "EndDate=@EndDate,WorkPhone=@WorkPhone,WorkAddress=@WorkAddress,WorkCity=@WorkCity,WorkState=@WorkState,WorkZip=@WorkZip,WorkPos=@WorkPos Where EmployeeID = @EmployeeID";
            //        SqlCommand cmd = new SqlCommand(Empl, conn);
            //        //Creating SQL Dataadapter using cmd
            //        //Creating Paramaters to add data
            //        cmd.Parameters.AddWithValue("@Name", c.Name);
            //        cmd.Parameters.AddWithValue("@Address", c.Address);
            //        cmd.Parameters.AddWithValue("@City", c.City);
            //        cmd.Parameters.AddWithValue("@State", c.State);
            //        cmd.Parameters.AddWithValue("@Zip", c.Zip);
            //        cmd.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);
            //        cmd.Parameters.AddWithValue("@Position", c.PositionDrop.SelectedValue);
            //        cmd.Parameters.AddWithValue("@StartDate", c.StartDate);
            //        cmd.Parameters.AddWithValue("@EndDate", c.EndDate);
            //        cmd.Parameters.AddWithValue("@WorkPhone", c.WorkPhone);
            //        cmd.Parameters.AddWithValue("@WorkAddress", c.WorkAddress);
            //        cmd.Parameters.AddWithValue("@WorkCity", c.WorkCity);
            //        cmd.Parameters.AddWithValue("@WorkState", c.WorkState);
            //        cmd.Parameters.AddWithValue("@WorkZip", c.WorkZip);
            //        cmd.Parameters.AddWithValue("@WorkPos", c.WorkPos);
            //        //cmd.Parameters.AddWithValue("@Supervisor", c.Sup);
            //        //cmd.Parameters.AddWithValue("@ReasonForLeaving", c.RFL);
            //        //open connection
            //        //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        conn.Open();
            //        int rows = cmd.ExecuteNonQuery();

            //        if (rows > 0)
            //        {
            //            isSuccess = true;
            //        }

            //        else
            //        {
            //            isSuccess = false;
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //    return isSuccess;


            //}

            //public bool Delete(WebForm1 c)
            //{
            //    bool isSuccessful = false;
            //    //Create your Sql connection
            //    SqlConnection conn = new SqlConnection(myconnstrng);

            //    try
            //    {
            //        string Empl = "Delete from EmployeenInfo  Where EmployeeID = @EmployeeID";
            //        SqlCommand cmd = new SqlCommand(Empl,conn);
            //        cmd.Parameters.AddWithValue("EmployeeID", c.@EmployeeID);
            //        conn.Open();
            //        int rows = cmd.EndExecuteNonQuery();
            //        if (rows > 0)
            //        {


            //        }

            //        else
            //        {


            //        }
                       
            //    }
            //    catch(Exception ex)
            //    {


            //    }

            //    finally
            //    {

            //        conn.Close
            //    }
            //    return isSuccessful;

            //}

//        }
        }
   }
}